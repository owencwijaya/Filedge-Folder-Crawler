using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace DirectoryTraversal.Lib
{
    using Algorithms;
    public class DirectoryTraversal
    {
        public DFS TraverseDFS;
        public BFS TraverseBFS;

        public DirectoryTraversal()
        {
            TraverseBFS = new();
            TraverseDFS = new();
        }
        public Action<FileInfo>? OnFile
        {
            get 
            {
                return TraverseDFS.OnFile; 
            }
            set 
            { 
                TraverseDFS.OnFile = value; 
                TraverseBFS.OnFile = value; 
            }
        }

        public Action<DirectoryInfo>? OnDirectory
        {
            get 
            { 
                return TraverseDFS.OnDirectory; 
            }
            set 
            { 
                TraverseDFS.OnDirectory = value; 
                TraverseBFS.OnDirectory = value; 
            }

        }

        public Action<FileInfo>? OnFound
        {
            get 
            { 
                return TraverseDFS.OnFound;
            }
            set 
            { 
                TraverseDFS.OnFound = value;
                TraverseBFS.OnFound = value;
            }
        }

   
        public int DrawDelay 
        { 
            get
            {
                return TraverseBFS.DrawDelay;
            }
            set
            {
                TraverseBFS.DrawDelay = value;
                TraverseDFS.DrawDelay = value;
            }
        }
        
        

    }
}
