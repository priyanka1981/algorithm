﻿using System;
using System.Collections.Generic;
namespace Algorithms.Tree
{
    public class Node<T> where T:IComparable 
    {
		T value;

		bool is_root = false;

		public Node<T> left_child;
		public Node<T> right_child;

		public Node<T> parent;

		public int height;
		public int depth;

		public bool isIs_root()
		{
			return is_root;
		}
		public void setIs_root(bool is_root)
		{
			this.is_root = is_root;
		}
		public Node<T> getLeft_child()
		{
			return left_child;
		}
		public void setLeft_child(Node<T> left_child)
		{
			this.left_child = left_child;
		}
		public Node<T> getRight_child()
		{
			return right_child;
		}
		public void setRight_child(Node<T> right_child)
		{
			this.right_child = right_child;
		}
		public int getHeight()
		{
			return height;
		}
		public void setHeight(int height)
		{
			this.height = height;
		}
		public int getDepth()
		{
			return depth;
		}
		public void setDepth(int depth)
		{
			this.depth = depth;
		}
		public T getValue()
		{
			return value;
		}
		public void setValue(T value)
		{
			this.value = value;
		}
		public Node<T> getParent()
		{
			return parent;
		}
		public void setParent(Node<T> parent)
		{
			this.parent = parent;
		}
		
	    public String toString()
		{
			return "Node [value=" + value + ", is_root=" + is_root
					+ ", left_child=" + left_child.getValue() + ", right_child=" + right_child.getValue()
					+ ", height=" + height + ", depth=" + depth + "]";
		}
    }
}
