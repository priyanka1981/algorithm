using System;
using System.Collections.Generic;
namespace Algorithms.Graph
{
    public class Graph<T>
    {
        public Node<int> root;
        public Graph()
        {
        }

        public Graph(Node<int> _root)
        {
            this.root = _root;
        }

        public void add(Node<int> ctx,Node<int> node)
        {
            ctx.adjustancyList.Add(node);
        }

        public void DFS()
        {
            Stack<Node<int>> stack = new Stack<Node<int>>();
            stack.Push(root);
            while(stack.Count>0)
            {
                Node<int> node = stack.Pop();
                Console.WriteLine(node.data);
                foreach (Node<int> _node in node.adjustancyList)
                {
                    stack.Push(_node);
                }
            }
        }

        public void BFS()
        {
            Queue<Node<int>> queue = new Queue<Node<int>>();
            queue.Enqueue(root); 
            while(queue.Count > 0)
            {
                Node<int> node= queue.Dequeue();
                Console.WriteLine(node.data);
                foreach(Node<int> _node in node.adjustancyList)
                {
                    queue.Enqueue(_node);
				}

            }
        }
    }
}
