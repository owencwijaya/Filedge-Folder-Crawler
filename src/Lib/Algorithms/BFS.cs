namespace DirectoryTraversal.Lib.Algorithms
{
    internal class BFS : TraversalAlgorithm, ITraversable
    {
        Queue<string> Q = new();
        Dictionary<string, bool> VisitedNodes = new();
        public BFS(int DrawDelay = 25)
        {
            this.DrawDelay = DrawDelay;
            this.isFound = false;
        }
        void TraverseBFS(string DirPath)
        {
            Q.Clear();
            VisitedNodes.Clear();
            VisitedNodes[DirPath] = true;
            Q.Enqueue(DirPath);

            while (Q.Count > 0)
            {
                string DeqNode = Q.Dequeue();
                DirectoryInfo DirMain = new(DeqNode);
                foreach (FileInfo File in DirMain.EnumerateFiles().Reverse())
                {
                    if (!VisitedNodes.ContainsKey(File.FullName))
                    {
                        OnFile?.Invoke(File);
                        if (File.Name == FileName)
                        {
                            FileResult.Append(File);
                            OnFound?.Invoke(File);
                            if (!AllOccurences)
                            {
                                Q.Clear();
                                VisitedNodes.Clear();
                                return;

                            }
                        }

                    }
                    Thread.Sleep(DrawDelay);
                }
                foreach (DirectoryInfo Directory in DirMain.EnumerateDirectories().Reverse())
                {
                    if (!VisitedNodes.ContainsKey(Directory.FullName))
                    {
                        OnDirectory?.Invoke(Directory);
                        Thread.Sleep(DrawDelay);
                        Q.Enqueue(Directory.FullName);
                    }
                }
            }
        }
        public void Traverse(string DirPath, string FileName, bool AllOccurance)
        {
            this.FileName = FileName;
            AllOccurences = AllOccurance;
            FileResult.Clear();
            TraverseBFS(DirPath);
        }
    }
}