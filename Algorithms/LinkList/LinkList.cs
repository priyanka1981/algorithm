using System;
using System.Collections.Generic;
namespace Algorithms.LinkList
{
    public class LinkList
    {
        public Node head;
        public Node Current;
        public LinkList()
        {
            
        }

        //static void Main(string[] args)
        //{
        //    LinkList linklist = new LinkList();
        //    Node node = new Node();
        //    node.value = 1;
        //    linklist.head = node;
        //    linklist.Current = node;
        //    linklist.Add(3);
        //    linklist.Add(5);
        //    linklist.Add(7);
        //    PrintAllNodes(linklist);
        //    //create_cycle(linklist);
        //    bool retCyclic = isCyclic(linklist);
        //    LinkList linklist2 = new LinkList();
        //    Node node1 = new Node();
        //    node1.value = 2;
        //    linklist2.head = node1;
        //    linklist2.Current = node;
        //    linklist2.Add(4);
        //    linklist2.Add(6);
        //    linklist2.Add(8);
        //    //foreach(Node node in linklist)
        //    //{
        //    //    MergeSortedList(node, linklist2.head);
        //    //}
        //    FindNThToLastElement(2, linklist);
          
        //}

        static  void PrintAllNodes(LinkList _linklist)
        {
            //Traverse from head
            Console.Write("Head ->");
            Node curr = _linklist.head;
            Console.Write(curr.value +"->");
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.value);
                Console.Write("->");
            }
            Console.Write("NULL");
        }

        public void Add(int data)
        {
            Node newNode = new Node();
            newNode.value = data;
            Current.Next = newNode;
            Current = newNode;
        }

        public void AddFirst(Node node)
        {
            node.Next = head.Next;
        }

       static  bool isCyclic(LinkList _linklist)
        {
            Node lag = _linklist.head;
            Node lead = _linklist.head.Next;
            while (lead.Next != null)
            {
                if (lag.Next == lead.Next)
                    return true;
                lead = lead.Next;
            }
                
            return false;
        }

        static void create_cycle(LinkList _linkList)
        {
            Node node = _linkList.head;
            while (node.Next != null)
                node = node.Next;
            node.Next = _linkList.head;

        }


        //static  void MergeSortedList(Node first, Node second)
        //{
        //    //we would be adding node from second list to first list
        //    //If second node data id more than first one then exchange it
        //    if (first.data.ToString().compareto(second.data.ToString()) > 0)
        //    {
        //        node t = first;
        //        first = second;
        //        second = first;
        //    }
        //    head = first;//Assign head to first Node

        //    while ((first.next != null) && (second != null))
        //    {
        //        if (Convert.ToInt32(first.next.data.ToString()) < Convert.ToInt32(first.data.ToString()))
        //        {
        //            first = first.next;//iterate over the first node
        //        }
        //        else
        //        {
        //            Node n = first.next;
        //            Node t = second.next;
        //            first.next = second;
        //            second.next = n;
        //            first = first.next;
        //            second = t;
        //        }
        //    }
        //    if (first.next = null)
        //    {
        //        first.next = second;
        //    }

        //}

        //public IEnumerator<T> GetEnumerator()
        //{
        //    return (IEnumerator)GetEnumerator();
        //}

        static void FindNThToLastElement(int x,LinkList _linklist)
        {
            Node lag = _linklist.head;
            Node lead = _linklist.head;
            for (int i = 1; i < x; i++)
                lead = lead.Next;
            while(lead.Next !=null){
                lag = lag.Next;
                lead = lead.Next;
            }
            int value = lag.value;
        }
        
      
    }

    public class Node
    {
        public int value;
        public Node Next;
    }
}
