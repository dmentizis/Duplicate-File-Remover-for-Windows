using DuplicateRemover.Objects;
using System.Security.Cryptography;

namespace DuplicateRemover;

public record ScanProgress(int Completed, int Total, string Path, int FilePercent);
public record ScanResult(List<UniqueFile> Files, int Found, int Skipped);
public record DeleteRequest(UniqueFile Group, string Path, string? KeepPath);
public static class LogicMethods
{
    public static readonly StringComparer PathComparer = StringComparer.OrdinalIgnoreCase;

    public static string ComputeFileHash(string filePath, CancellationToken cancellation = default,
        Action<long, long>? progress = null)
    {
        if ((File.GetAttributes(filePath) & FileAttributes.ReparsePoint) != 0)
            throw new IOException("Symbolic links and reparse points are excluded.");
        using var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read,
            1024 * 1024, FileOptions.SequentialScan);
        return HashStream(stream, cancellation, progress);
    }

    private static string HashStream(Stream stream, CancellationToken cancellation = default, Action<long, long>? progress = null)
    {
        using var hash = IncrementalHash.CreateHash(HashAlgorithmName.SHA256);
        var buffer = new byte[1024 * 1024];
        long readTotal = 0;
        int count;
        cancellation.ThrowIfCancellationRequested();
        while ((count = stream.Read(buffer, 0, buffer.Length)) > 0)
        {
            cancellation.ThrowIfCancellationRequested();
            hash.AppendData(buffer, 0, count);
            readTotal += count;
            progress?.Invoke(readTotal, stream.Length);
        }
        cancellation.ThrowIfCancellationRequested();
        return Convert.ToHexString(hash.GetHashAndReset());
    }

    public static ScanResult Scan(string directory, bool recursive, CancellationToken cancellation,
        Action<ScanProgress> progress, Action<string> warning)
    {
        if (!Directory.Exists(directory)) throw new DirectoryNotFoundException(directory);
        var paths = new List<string>();
        var pending = new Stack<string>();
        pending.Push(Path.GetFullPath(directory));
        int skipped = 0;
        while (pending.TryPop(out var folder))
        {
            cancellation.ThrowIfCancellationRequested();
            try
            {
                if ((File.GetAttributes(folder) & FileAttributes.ReparsePoint) != 0)
                {
                    warning($"Skipped linked folder: {folder}");
                    continue;
                }
                foreach (var entry in Directory.EnumerateFileSystemEntries(folder))
                {
                    cancellation.ThrowIfCancellationRequested();
                    try
                    {
                        var attributes = File.GetAttributes(entry);
                        if ((attributes & FileAttributes.ReparsePoint) != 0)
                        {
                            warning($"Skipped link: {entry}");
                            continue;
                        }
                        if ((attributes & FileAttributes.Directory) != 0)
                        {
                            if (recursive) pending.Push(entry);
                        }
                        else paths.Add(entry);
                    }
                    catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
                    {
                        skipped++;
                        warning($"Cannot inspect {entry}: {ex.Message}");
                    }
                }
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
            {
                skipped++;
                warning($"Cannot read folder {folder}: {ex.Message}");
            }
        }
        paths.Sort(PathComparer);
        var groups = new Dictionary<string, UniqueFile>(StringComparer.Ordinal);
        for (int i = 0; i < paths.Count; i++)
        {
            cancellation.ThrowIfCancellationRequested();
            var path = paths[i];
            progress(new(i, paths.Count, path, 0));
            try
            {
                var hash = ComputeFileHash(path, cancellation, (done, total) =>
                    progress(new(i, paths.Count, path, total == 0 ? 100 : (int)(100d * done / total))));
                if (!groups.TryGetValue(hash, out var group))
                    groups.Add(hash, group = new UniqueFile { Hash = hash });
                group.Paths.Add(path);
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
            {
                skipped++;
                warning($"Skipped {path}: {ex.Message}");
            }
            progress(new(i + 1, paths.Count, path, 100));
        }
        cancellation.ThrowIfCancellationRequested();
        return new(groups.Values.ToList(), paths.Count, skipped);
    }

    public static List<DeleteRequest> PlanKeep(UniqueFile group, string keeper)
    {
        if (!group.Paths.Contains(keeper, PathComparer)) throw new ArgumentException("The retained path is not in this group.");
        return group.Paths.Where(p => !PathComparer.Equals(p, keeper))
            .Select(p => new DeleteRequest(group, p, keeper)).ToList();
    }

    public static List<DeleteRequest> PlanAutoClean(IEnumerable<UniqueFile> groups) => groups
        .Where(g => g.Paths.Count > 1)
        .SelectMany(g => PlanKeep(g, g.Paths.OrderBy(p => p, PathComparer).First())).ToList();

    private static FileStream OpenKeeper(string path)
    {
        if ((File.GetAttributes(path) & FileAttributes.ReparsePoint) != 0)
            throw new IOException("The retained file is now a link. Scan again.");
        return new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
    }

    public static void ExecuteDelete(DeleteRequest request)
    {
        if (!request.Group.Paths.Contains(request.Path, PathComparer))
            throw new InvalidOperationException("The selected path is no longer in this group.");
        // Refuse stale scan results; a missing or changed keeper must never authorize deletion.
        using var keeper = request.KeepPath == null ? null : OpenKeeper(request.KeepPath);
        if (request.KeepPath != null)
        {
            if (PathComparer.Equals(request.Path, request.KeepPath))
                throw new InvalidOperationException("Cannot delete the retained copy.");
            if (HashStream(keeper!) != request.Group.Hash)
                throw new IOException("The retained file changed since scanning. Scan again.");
        }
        if (ComputeFileHash(request.Path) != request.Group.Hash)
            throw new IOException("The selected file changed since scanning. Scan again.");
        File.Delete(request.Path);
        request.Group.Paths.Remove(request.Path);
    }
}
