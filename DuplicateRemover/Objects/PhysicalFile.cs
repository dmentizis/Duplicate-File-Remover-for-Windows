namespace DuplicateRemover.Objects
{
    public class PhysicalFile
    {
        public required string Path { get; set; }
        public long SizeInBytes { get; set; }
        public string? Extension { get; set; }
        public required string Hash { get; set; }
    }
}