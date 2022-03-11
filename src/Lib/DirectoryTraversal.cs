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
        static ITraversalAlgorithm bfs = new BFS();
        static ITraversalAlgorithm dfs = new DFS();
        
        public static void TraverseFromDirectory<T>(string startDirectory, Action<T, T> onEdgeCallback)
        {

        }

        public static void TraverseFromRoot<T>(string root, Action<T, T> onEdgeCallback)
        {
        }
    }
}
