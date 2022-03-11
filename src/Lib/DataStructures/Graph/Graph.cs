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
        public GraphNode(T info, ref LinkedList<Node<T>>? neighbors) : base(info, ref neighbors)
        {
        }
    }

    public class Graph<T>
    {
        GraphNode<T> root;
        public GraphNode<T> Root
        {
            get { return root; }
            set { root = value; }
        }
        public Graph()
        {
            GraphNode<int> a = new GraphNode<int>(1);
        }
        public void AddNode(ref GraphNode<T> node)
        {

        }
        public void AddNode(T info)
        {

        }
        public void AddEdge(ref GraphNode<T> from, ref GraphNode<T> to)
        {

        }
    }
}
