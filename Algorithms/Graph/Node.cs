using System;
using System.Collections.Generic;
namespace Algorithms.Graph
{
    public class Node<T>
    {
		public T data;
        public List<Node<T>> adjustancyList = new List<Node<T>>();
        public Node()
        {
        }

        public Node(T _data)
        {
            this.data = _data;
        }

       

    }
}
