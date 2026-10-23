using DuplicateRemover.Controls;
using System.ComponentModel;
using DuplicateRemover.Objects;

namespace DuplicateRemover;

public partial class Form1 : Form
{
    private List<UniqueFile> _files = [];
    private CancellationTokenSource? _cancellation;
    private bool _busy;
    private bool _closeWhenDone;
    private readonly BackgroundWorker _worker = new() { WorkerReportsProgress = true };

    public Form1()
    {
        InitializeComponent();
        directory.TextChanged += (_, _) => UpdateActions();
        log.TextChanged += (_, _) => UpdateActions();
        Activated += (_, _) => UpdateActions();
        _worker.DoWork += ScanWork;
        _worker.ProgressChanged += (_, e) =>
        {
            if (e.UserState is string message) Log("WARN", message);
            if (e.UserState is ScanProgress p)
            {
                progress.Style = ProgressBarStyle.Continuous;
                progress.Value = e.ProgressPercentage;
                status.Text = $"Hashing: {p.Completed:N0} / {p.Total:N0} files • Current file {p.FilePercent}% • {p.Path}";
            }
        };
        _worker.RunWorkerCompleted += (_, e) =>
        {
            bool cancelled = e.Cancelled || _cancellation?.IsCancellationRequested == true;
            _cancellation?.Dispose();
            _cancellation = null;
            progress.Style = ProgressBarStyle.Continuous;
            if (cancelled)
            {
                progress.Value = 0;
                status.Text = "Scan cancelled. Partial results discarded.";
                Log("INFO", status.Text);
            }
            else if (e.Error != null)
            {
                progress.Value = 0;
                status.Text = "Scan failed. See activity log.";
                Log("ERROR", e.Error.Message);
            }
            else if (e.Result is ScanResult result)
            {
                _files = result.Files;
                progress.Value = 100;
                status.Text = $"Scan complete • {result.Found:N0} files found • {result.Skipped:N0} items/folders skipped";
                Log("INFO", status.Text);
            }
            SetBusy(false);
            RefreshResults();
            if (_closeWhenDone) Close();
        };
        FormClosing += (_, e) =>
        {
            if (!_busy) return;
            e.Cancel = true;
            _closeWhenDone = true;
            _cancellation?.Cancel();
            status.Text = "Finishing the current operation before closing…";
        };
        RefreshResults();
    }

    protected override void OnLoad(EventArgs e)
    {
        // Apply after initial DPI scaling, when the window's target monitor is known.
        var workingArea = Screen.FromControl(this).WorkingArea;
        MinimumSize = new Size(Math.Min(LogicalToDeviceUnits(940), workingArea.Width),
            Math.Min(LogicalToDeviceUnits(720), workingArea.Height));
        Size = new Size(Math.Min(Width, workingArea.Width), Math.Min(Height, workingArea.Height));
        Location = new Point(workingArea.Left + (workingArea.Width - Width) / 2,
            workingArea.Top + (workingArea.Height - Height) / 2);
        base.OnLoad(e);
    }

    private void Browse(object? sender, EventArgs e)
    {
        using var dialog = new FolderBrowserDialog { Description = "Choose a folder to find identical file contents", UseDescriptionForTitle = true };
        if (dialog.ShowDialog(this) == DialogResult.OK) directory.Text = dialog.SelectedPath;
    }

    private void StartScan(object? sender, EventArgs e)
    {
        if (_busy) return;
        if (!Directory.Exists(directory.Text))
        {
            MessageBox.Show(this, "Choose an existing folder first.", "Folder required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        _files.Clear();
        RefreshResults();
        _cancellation = new CancellationTokenSource();
        SetBusy(true);
        progress.Value = 0;
        progress.Style = ProgressBarStyle.Marquee;
        status.Text = "Discovering files…";
        Log("INFO", $"Scanning {directory.Text} (subfolders: {subfolders.Checked}).");
        _worker.RunWorkerAsync((directory.Text, subfolders.Checked, _cancellation.Token));
    }

    private void ScanWork(object? sender, DoWorkEventArgs e)
    {
        var (path, recursive, token) = ((string, bool, CancellationToken))e.Argument!;
        var timer = System.Diagnostics.Stopwatch.StartNew();
        try
        {
            e.Result = LogicMethods.Scan(path, recursive, token, p =>
            {
                if (timer.ElapsedMilliseconds < 100 && p.Completed != p.Total) return;
                timer.Restart();
                int percent = p.Total == 0 ? 100 : (int)(100d * p.Completed / p.Total);
                _worker.ReportProgress(percent, p);
            }, warning => _worker.ReportProgress(0, warning));
        }
        catch (OperationCanceledException) { e.Cancel = true; }
    }

    private UniqueFile? SelectedGroup => files.SelectedItem as UniqueFile;

    private void RefreshResults()
    {
        string? selectedHash = SelectedGroup?.Hash;
        files.BeginUpdate();
        files.Items.Clear();
        foreach (var group in _files.Where(g => g.Paths.Count > 0)
            .Where(g => filter.SelectedIndex != 1 || g.Paths.Count > 1)
            .Where(g => filter.SelectedIndex != 2 || g.Paths.Count == 1))
            files.Items.Add(group);
        files.EndUpdate();
        files.SelectedItem = files.Items.Cast<UniqueFile>().FirstOrDefault(g => g.Hash == selectedHash);
        if (files.SelectedIndex < 0 && files.Items.Count > 0) files.SelectedIndex = 0;
        ShowPaths();
        summary.Text = $"{_files.Sum(g => g.Paths.Count):N0} files  •  {_files.Count(g => g.Paths.Count > 0):N0} distinct contents  •  {_files.Sum(g => Math.Max(0, g.Paths.Count - 1)):N0} extra copies";
        UpdateActions();
    }

    private void ShowPaths()
    {
        paths.Items.Clear();
        if (SelectedGroup is { } group)
        {
            paths.Items.AddRange(group.Paths.OrderBy(p => p, LogicMethods.PathComparer).ToArray());
            hash.Text = $"SHA-256: {group.Hash}";
            if (paths.Items.Count > 0) paths.SelectedIndex = 0;
        }
        else hash.Text = "Select a file to see every full path.";
        UpdateActions();
    }

    private void SetBusy(bool busy)
    {
        _busy = busy;
        browse.Enabled = scan.Enabled = directory.Enabled = subfolders.Enabled = filter.Enabled = files.Enabled = paths.Enabled = !busy;
        cancel.Enabled = busy && _cancellation != null;
        UpdateActions();
    }

    private void UpdateActions()
    {
        bool idle = !_busy && !_closeWhenDone;
        bool hasResults = idle && _files.Any(g => g.Paths.Count > 0);
        bool hasSelection = idle && SelectedGroup != null && paths.SelectedItem != null;
        browse.Enabled = directory.Enabled = subfolders.Enabled = idle;
        scan.Enabled = idle && Directory.Exists(directory.Text);
        cancel.Enabled = _busy && !_closeWhenDone && _cancellation is { IsCancellationRequested: false };
        filter.Enabled = hasResults;
        files.Enabled = idle && files.Items.Count > 0;
        paths.Enabled = idle && paths.Items.Count > 0;
        autoClean.Enabled = idle && _files.Any(g => g.Paths.Count > 1);
        keepFirst.Enabled = idle && SelectedGroup?.Paths.Count > 1;
        keepSelected.Enabled = hasSelection && SelectedGroup?.Paths.Count > 1;
        deleteSelected.Enabled = openFolder.Enabled = hasSelection;
        saveLog.Enabled = clearLog.Enabled = idle && log.TextLength > 0;
    }
    private async Task DeleteAsync(List<DeleteRequest> requests, string description)
    {
        if (_busy || requests.Count == 0) return;
        var preview = string.Join(Environment.NewLine, requests.Take(6).Select(r => r.Path));
        var retained = requests.Select(r => r.KeepPath).Where(p => p != null).Distinct().ToList();
        string keep = retained.Count == 1 ? $"\n\nKeep: {retained[0]}" : retained.Count > 1 ? "\n\nKeep the first path in each group (ordinal, case-insensitive order)." : "";
        if (MessageBox.Show(this, $"{description}\n\nPermanently delete {requests.Count:N0} file(s)?{keep}\n\n{preview}" +
            (requests.Count > 6 ? "\n…" : "") + "\n\nThis does not use the Recycle Bin.", "Confirm deletion", MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
        SetBusy(true);
        progress.Value = 0;
        int deleted = 0, failed = 0;
        var updates = new Progress<(int Done, string Level, string Message)>(p =>
        {
            progress.Value = (int)(100d * p.Done / requests.Count);
            status.Text = $"Cleanup: {p.Done:N0} / {requests.Count:N0}";
            Log(p.Level, p.Message);
        });
        try
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < requests.Count; i++)
                {
                    var request = requests[i];
                    try
                    {
                        LogicMethods.ExecuteDelete(request);
                        deleted++;
                        ((IProgress<(int, string, string)>)updates).Report((i + 1, "INFO", $"Deleted {request.Path}"));
                    }
                    catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or InvalidOperationException)
                    {
                        failed++;
                        ((IProgress<(int, string, string)>)updates).Report((i + 1, "ERROR", $"Kept {request.Path}: {ex.Message}"));
                    }
                }
            });
        }
        catch (Exception ex) { Log("ERROR", ex.Message); }
        finally
        {
            _files.RemoveAll(g => g.Paths.Count == 0);
            SetBusy(false);
            RefreshResults();
            status.Text = $"Cleanup finished • {deleted:N0} deleted • {failed:N0} failed";
            Log("INFO", status.Text);
            if (_closeWhenDone) Close();
        }
    }

    private void Log(string level, string message)
    {
        if (log.TextLength > 150000) { log.Select(0, 50000); log.SelectedText = ""; }
        log.SelectionStart = log.TextLength;
        log.SelectionColor = level == "ERROR" ? Color.FromArgb(255, 143, 143) : level == "WARN" ? Color.FromArgb(245, 202, 112) : AppTheme.Text;
        log.AppendText($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}{Environment.NewLine}");
        log.ScrollToCaret();
    }

    private void OpenSelectedFolder(object? sender, EventArgs e)
    {
        if (_busy || paths.SelectedItem is not string selectedPath) return;
        try
        {
            string? folder = Path.GetDirectoryName(Path.GetFullPath(selectedPath));
            if (folder == null || !Directory.Exists(folder))
                throw new DirectoryNotFoundException("The selected file's folder no longer exists. Scan again to refresh the paths.");
            var start = new System.Diagnostics.ProcessStartInfo
            {
                FileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "explorer.exe"),
                UseShellExecute = true
            };
            start.ArgumentList.Add(folder);
            using var process = System.Diagnostics.Process.Start(start);
            Log("INFO", $"Opened folder: {folder}");
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or Win32Exception or ArgumentException)
        {
            Log("ERROR", $"Could not open folder: {ex.Message}");
            MessageBox.Show(this, ex.Message, "Cannot open folder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    private void SaveLog(object? sender, EventArgs e)
    {
        using var dialog = new SaveFileDialog { Filter = "Text log (*.txt)|*.txt", FileName = $"duplicate-remover-{DateTime.Now:yyyyMMdd-HHmmss}.txt" };
        if (dialog.ShowDialog(this) != DialogResult.OK) return;
        try { File.WriteAllText(dialog.FileName, log.Text); }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException) { Log("ERROR", $"Could not save log: {ex.Message}"); }
    }
}
