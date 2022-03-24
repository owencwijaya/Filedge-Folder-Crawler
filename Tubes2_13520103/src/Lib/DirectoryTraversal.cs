namespace DirectoryTraversal.Lib
{
    using Algorithms;

    public enum Algorithm
    {
        DFS,
        BFS
    }
    public class DirectoryTraversal
    {
        readonly BFS TraverseBFS = new();
        readonly DFS TraverseDFS = new();

        public Action<FileInfo>? OnVisitedFile
        {
            set
            {
                TraverseDFS.OnVisitedFile = value;
                TraverseBFS.OnVisitedFile = value;
            }
        }
        public Action<DirectoryInfo>? OnVisitedDirectory
        {
            set
            {
                TraverseDFS.OnVisitedDirectory = value;
                TraverseBFS.OnVisitedDirectory = value;
            }
        }
        public Action<FileInfo>? OnFile
        {
            set 
            { 
                TraverseDFS.OnFile = value; 
                TraverseBFS.OnFile = value; 
            }
        }

        public Action<DirectoryInfo>? OnDirectory
        {
            set 
            { 
                TraverseDFS.OnDirectory = value; 
                TraverseBFS.OnDirectory = value; 
            }

        }

        public Action<FileInfo>? OnFound
        {
            set 
            { 
                TraverseDFS.OnFound = value;
                TraverseBFS.OnFound = value;
            }
        }
        public int DrawDelay 
        {
            set
            {
                TraverseBFS.DrawDelay = value;
                TraverseDFS.DrawDelay = value;
            }
        }
        public void Traverse(string DirPath, string FileName, bool AllOccurances, Algorithm Algo)
        {
            if (Algo == Algorithm.BFS)
            {
                TraverseBFS.Traverse(DirPath, FileName, AllOccurances);
            } 
            else if(Algo == Algorithm.DFS)
            {
                TraverseDFS.Traverse(DirPath, FileName, AllOccurances);
            }
        }

    }
}
