namespace DirectoryTraversal.Lib.Algorithms
{
    public abstract class TraversalAlgorithm
    {
        public Action<FileInfo>? OnFile;
        public Action<FileInfo>? OnFound;
        public Action<DirectoryInfo>? OnDirectory;
        public string? FileName { get; set; }
        public int DrawDelay { get; set; }
        public bool IsFound { get; set; }
        internal bool AllOccurences { get; set; }
    }
    public interface ITraversable
    {
        void Traverse(string DirPath, string FileName, bool AllOccurance);
    }
}
