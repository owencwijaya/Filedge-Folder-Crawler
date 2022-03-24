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
            // Jika sudah ketemu dan tak cek alloccurence, skip smua backtrack.
            if (!AllOccurences && IsFound)
                return;
            DirectoryInfo DirMain = new(DirPath);

            // Bangkitkan simpul hidup
            foreach (DirectoryInfo Directory in DirMain.EnumerateDirectories().Reverse())
            {
                OnDirectory?.Invoke(Directory);
                Thread.Sleep(DrawDelay);
            }
            foreach (FileInfo File in DirMain.EnumerateFiles().Reverse())
            {
                OnFile?.Invoke(File);
                Thread.Sleep(DrawDelay);
            }

            // Visit semua node simpul hidup
            foreach (FileInfo File in DirMain.EnumerateFiles())
            {
                OnVisitedFile?.Invoke(File);
                if (File.Name == FileName)
                {
                    IsFound = true;
                    OnFound?.Invoke(File);
                    if (!AllOccurences)
                        return;
                }
                Thread.Sleep(DrawDelay);
            }
            foreach (DirectoryInfo Directory in DirMain.EnumerateDirectories())
            {
                // Bangkitkan simpul ekspan
                OnVisitedDirectory?.Invoke(Directory);
                TraverseDFS(Directory.FullName);
                // Jika sudah ketemu dan tak cek alloccurence, skip checking setelahnya.
                if (!AllOccurences && IsFound)
                    return;
                Thread.Sleep(DrawDelay);
            }
        }
        public void Traverse(string DirPath, string FileName, bool AllOccurances)
        {
            this.FileName = FileName;
            this.AllOccurences = AllOccurances;
            IsFound = false;
            TraverseDFS(DirPath);
        }
    }
}
