using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryTraversal.Lib.DataStructures.Graph
{
    public class Node<T>
    {
        T info;
        LinkedList<Node<T>>? neighbors = null;
        public LinkedList<Node<T>>? Neighbors
        {
            get
            {
                return neighbors;
            }
        }
        public T Info
        {
            get
            {
                return info;
            }
            set
            {
                info = value;
            }
        }

        public Node(T data)
        {
            info = data;
        }

        public Node(T data, ref LinkedList<Node<T>>? neighbors)
        {
            info = data;
            this.neighbors = neighbors;
        }

        public void AddNeighbor(ref Node<T> node)
        {
            neighbors?.AddLast(node);
        }
    }
}
