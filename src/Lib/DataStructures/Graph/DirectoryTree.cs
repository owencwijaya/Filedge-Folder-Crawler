using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryTraversal.Lib.DataStructures.Graph
{
    public class DirectoryTree
    {
        Graph<string> dirtree;
        public Graph<string> Tree
        {
            get { return dirtree; }
        }

        public DirectoryTree(string rootDirectory)
        {
            DirectoryInfo dir = new(rootDirectory);
            if (dir.Exists)
            {
                dir.GetDirectories().Select(x => x.FullName);
            } else
            {
                throw new DirectoryNotFoundException(rootDirectory);
            }
        }
    }
}
