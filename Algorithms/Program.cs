using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree();
        }

        static void Tree()
        {
            Algorithms.Tree.Node<int> root = new Algorithms.Tree.Node<int>();
            root.setValue(2);
           
            Algorithms.Tree.Node<int> left = new Algorithms.Tree.Node<int>();
            left.setValue(1);
            Algorithms.Tree.Tree<int> tree = new Algorithms.Tree.Tree<int>(root);
            tree.addChild(left);
			Algorithms.Tree.Node<int> right = new Algorithms.Tree.Node<int>();
			right.setValue(4);
            tree.addChild(right);
            tree.inOrderTraversal(root);
        }
    }
}
