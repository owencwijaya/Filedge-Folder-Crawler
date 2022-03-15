namespace DirectoryTraversal.Lib.Algorithms
{
    public class DFS : TraversalAlgorithm, ITraversable
    {
        
        public DFS(int DrawDelay = 25)
        {
            this.DrawDelay = DrawDelay;
            this.isFound = false;
        }
        void TraverseDFS(string DirPath)
        {
            DirectoryInfo DirMain = new(DirPath);
            foreach (FileInfo File in DirMain.EnumerateFiles().Reverse())
            {
                if (!AllOccurences && isFound)
                {
                    return;
                }
                OnFile?.Invoke(File);
                if (File.Name == FileName)
                {
                    isFound = true;
                    FileResult.Append(File);
                    OnFound?.Invoke(File);
                }
                Thread.Sleep(DrawDelay);
            }

            foreach (DirectoryInfo Directory in DirMain.EnumerateDirectories().Reverse())
            {
                if (!AllOccurences && isFound)
                {
                    return;
                }

                OnDirectory?.Invoke(Directory);
                Thread.Sleep(DrawDelay);

                if (AllOccurences || (!isFound && !AllOccurences))
                {
                    TraverseDFS(Directory.FullName);
                }
            }
            
        }

        public void Traverse(string DirPath, string FileName, bool AllOccurance)
        {
            this.FileName = FileName;
            AllOccurences = AllOccurance;
            FileResult.Clear();
            TraverseDFS(DirPath);
        }
    }
}
