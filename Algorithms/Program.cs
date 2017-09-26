using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void Tree()
        {
            Algorithms.Tree.Node<int> root = new Algorithms.Tree.Node<int>();
            root.setValue(2);
            Algorithms.Tree.Node<int> left = new Algorithms.Tree.Node<int>();
            left.setValue(1);
			Algorithms.Tree.Node<int> right = new Algorithms.Tree.Node<int>();
			left.setValue(4);
        }
    }
}
