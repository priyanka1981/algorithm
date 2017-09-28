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
            root.setValue(3);
            root.setIs_root(true); 
            Algorithms.Tree.Node<int> left = new Algorithms.Tree.Node<int>();
            left.setValue(2);
            Algorithms.Tree.Tree<int> tree = new Algorithms.Tree.Tree<int>(root);
			Algorithms.Tree.Node<int> left_left = new Algorithms.Tree.Node<int>();
            left_left.setValue(1);
            tree.addChild(left);
			tree.addChild(left_left);
			Algorithms.Tree.Node<int> right = new Algorithms.Tree.Node<int>();
			right.setValue(4);
            tree.addChild(right);
            tree.printTree("in");
			tree.printTree("pre");
            tree.printTree("post");
        }
		
    }
}
