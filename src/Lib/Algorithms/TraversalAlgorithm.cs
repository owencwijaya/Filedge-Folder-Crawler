using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DirectoryTraversal.Lib.Algorithms
{
    public abstract class TraversalAlgorithm
    {
        public Action<FileInfo>? OnFile;
        public Action<FileInfo>? OnFound;
        public Action<DirectoryInfo>? OnDirectory;
        public string? FileName { get; set; }
        public List<FileInfo> FileResult = new();
        public int DrawDelay { get; set; }
        internal bool AllOccurences { get; set; }
    }
    public interface ITraversable
    {
        void Traverse(string DirPath, string FileName, bool AllOccurance);
    }
}
