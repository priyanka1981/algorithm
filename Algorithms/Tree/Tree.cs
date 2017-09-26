using System;
using System.Collections.Generic;
namespace Algorithms.Tree
{
    public class Tree<T>
    {

		Node<int> root;

		bool is_balancing = false;

		public Tree(Node<int> root)
		{
			this.root = root;
			root.height = 0; // increases by one on adding additional element to either side of the tree (revisit for balanced tree)
			root.depth = 0; // remains the same since root will be highest level node always
		}

		public Tree(Node<int> root, bool is_balancing)
		{
			this.is_balancing = is_balancing;
			this.root = root;
			root.height = 0; // increases by one on adding additional element to either side of the tree (revisit for balanced tree)
			root.depth = 0; // remains the same since root will be highest level node always
		}

		public String addChild(Node<int> node)
		{
			node.height = 0;
			node.depth = 0;
			this.addChild(root, node);

			return "";
		}

		public void addChild(Node<int> node_1, Node<int> node)
		{
			if (node.getValue().CompareTo(node_1.getValue()) < 0)
			{
				if (node_1.getLeft_child() != null)
				{
					// REVISIT
					// with every call to addChild on the left-node, root elements goes one level higher, and this node goes one down
					root.height += 1;
					node_1.left_child.height += 1;
					node.depth += 1;
					addChild(node_1.getLeft_child(), node);
				}
				else
				{
					node_1.left_child = node;

					if (this.is_balancing) node.parent = node_1;
				}
			}
			else
			{
				if (node_1.getRight_child() != null)
				{
					// REVISIT
					// with every call to addChild on the right-node, root elements goes one level higher, and this node goes one down
					root.height += 1;
					node_1.left_child.height += 1;
					node.depth += 1;
					addChild(node_1.getRight_child(), node);
				}
				else
				{
					node_1.right_child = node;

					if (this.is_balancing) node.parent = node_1;
				}
			}

			return;
		}

		/**
		 * mode = in, pre, post
		 * @param mode
		 */
		public void printTree(String mode)
		{
			switch (mode)
			{
				case "in": this.inOrderTraversal(this.root); break;
				case "pre": this.preOrderTraversal(this.root); break;
				case "post": this.postOrderTraversal(this.root); break;
				default: break;
			}
		}

		public void inOrderTraversal(Node<int> root)
		{
			if (root == null) return;

			// print root, print left-tree, print right-tree
			Console.WriteLine(root.toString());
			inOrderTraversal(root.left_child);
			inOrderTraversal(root.right_child);
			return;
		}

		public void preOrderTraversal(Node<int> root)
		{
			if (root == null) return;

			// print left-tree, print root, print right-tree
			preOrderTraversal(root.left_child);
			Console.WriteLine(root.toString());
			preOrderTraversal(root.right_child);
			return;
		}

		public void postOrderTraversal(Node<int> root)
		{
			if (root == null) return;

			// print left-tree, print right-tree, print root 
			postOrderTraversal(root.left_child);
			postOrderTraversal(root.right_child);
			Console.WriteLine(root.toString());
			return;
		}

		/**
		 * The tree can be rotated on it's node in the clock-wise or anti-clock-wide directions. <br> This can be achieved by 
		 * <br> clock-wise rotation:
		 * <br> (1) left-node of the root gets assigned to the root
		 * <br> (2) right-node of the root gets assigned to the root
		 * <p> To be able to rotate, the child node needs to know the parent-node's reference
		 * @param root
		 */
		/*public void rotateTheNode(Node<T> node, String clock_or_anti)
		{
			if (!this.is_balancing) return; // Rotation is not enabled

			switch (clock_or_anti)
			{
				case "clock":
					if (node.left_child == null) return;
					Node<V> parent = node.parent;
					Node<V> left_node = node.left_child;
					Node<V> right_node = node.right_child;

					Node<V> parent_left = parent.left_child;
					Node<V> parent_right = parent.right_child;

					if (parent_left != null && parent_left.equals(node))
					{
						parent.left_child = left_node;
						node.parent = left_node;
					}
					else if (parent_right != null && parent_right.equals(node))
					{
						parent.right_child = left_node;
						node.parent = left_node;
					}
				case "anti":
					if (node.right_child == null) return;
				default: return;
			}
		}**/
    }
}
