using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryTraversal.Lib.DataStructures.Graph
{
    public class GraphNode<T> : Node<T>
    {
        public GraphNode(T info) : base(info)
        {
        }
        public GraphNode(T info, ref LinkedList<Node<T>> neighbors) : base(info, ref neighbors)
        {
        }
    }

    public class Graph<T>
    {
        Node<T> root;
        public Node<T> Root
        {
            get { return root; }
            set { root = value; }
        }
        public Graph(Node<T> root)
        {
            this.root = root;
        }
    }
}
