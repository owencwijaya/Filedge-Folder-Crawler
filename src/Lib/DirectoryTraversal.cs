using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

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
        private static BFS TraverseBFS;
        private static DFS TraverseDFS;

        public DirectoryTraversal()
        {
            TraverseBFS = new BFS();
            TraverseDFS = new DFS();
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
