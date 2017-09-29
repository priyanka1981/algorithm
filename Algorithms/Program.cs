using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph();
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

        static void Graph()
        {
            Algorithms.Graph.Node<int> root = new Algorithms.Graph.Node<int>();
            root.data = 2;
			Algorithms.Graph.Node<int> node1 = new Algorithms.Graph.Node<int>();
			node1.data = 1;
			Algorithms.Graph.Node<int> node2 = new Algorithms.Graph.Node<int>();
			node2.data = 4;
			Algorithms.Graph.Node<int> node3 = new Algorithms.Graph.Node<int>();
			node3.data = 5;
            Algorithms.Graph.Graph<int> graph = new Algorithms.Graph.Graph<int>(root);
            graph.add(root, node1);
            graph.add(root,node2);
            graph.add(node1,node3); 
            graph.BFS();
            graph.DFS();
        }
		
    }
}
