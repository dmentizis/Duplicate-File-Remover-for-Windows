namespace DuplicateRemover.Objects;

public class UniqueFile
{
    public required string Hash { get; set; }
    public List<string> Paths { get; set; } = [];
    public override string ToString() => $"{System.IO.Path.GetFileName(Paths.FirstOrDefault())}   —   {Paths.Count} {(Paths.Count == 1 ? "copy" : "copies")}";
}
