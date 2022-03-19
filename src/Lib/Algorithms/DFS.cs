namespace DirectoryTraversal.Lib.Algorithms
{
    internal class DFS : TraversalAlgorithm, ITraversable
    {
        public DFS(int DrawDelay = 25)
        {
            this.DrawDelay = DrawDelay;
            IsFound = false;
        }
        void TraverseDFS(string DirPath)
        {

            DirectoryInfo DirMain = new(DirPath);
            foreach (FileInfo File in DirMain.EnumerateFiles().Reverse())
            {
                if (!AllOccurences && IsFound)
                {
                    return;
                }
                OnFile?.Invoke(File);
                if (File.Name == FileName)
                {
                    IsFound = true;
                    OnFound?.Invoke(File);
                }
                Thread.Sleep(DrawDelay);
            }

            foreach (DirectoryInfo Directory in DirMain.EnumerateDirectories().Reverse())
            {
                if (!AllOccurences && IsFound)
                {
                    return;
                }

                OnDirectory?.Invoke(Directory);
                Thread.Sleep(DrawDelay);

                if (AllOccurences || (!IsFound && !AllOccurences))
                {
                    TraverseDFS(Directory.FullName);
                }
            }
            
        }
        public void Traverse(string DirPath, string FileName, bool AllOccurance)
        {
            this.FileName = FileName;
            AllOccurences = AllOccurance;
            IsFound = false;
            TraverseDFS(DirPath);
        }
    }
}
