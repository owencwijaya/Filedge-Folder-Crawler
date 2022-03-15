namespace DirectoryTraversal.Lib.Algorithms
{
    public class DFS : TraversalAlgorithm, ITraversable
    {
        
        public DFS(int DrawDelay = 25)
        {
            this.DrawDelay = DrawDelay;
        }
        void TraverseDFS(string DirPath)
        {
            DirectoryInfo DirMain = new(DirPath);

            foreach (FileInfo File in DirMain.EnumerateFiles().Reverse())
            {
                OnFile?.Invoke(File);
                if (File.Name == FileName)
                {
                    FileResult.Append(File);
                    OnFound?.Invoke(File);
                    if (!AllOccurences)
                    {
                        return;
                    }
                }
                Thread.Sleep(DrawDelay);
            }

            foreach (DirectoryInfo Directory in DirMain.EnumerateDirectories().Reverse())
            {
                OnDirectory?.Invoke(Directory);
                Thread.Sleep(DrawDelay);
                TraverseDFS(Directory.FullName);
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
