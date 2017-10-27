using System;
namespace Algorithms.LinkList
{
    public class LinkList
    {
        public Node head;
        public Node Current;
        public LinkList()
        {
            
        }

        static void Main(string[] args)
        {
            LinkList linklist = new LinkList();
            Node node = new Node();
            node.value = 1;
            linklist.head = node;
            linklist.Current = node;
            linklist.Add(2);
            linklist.Add(3);
            linklist.Add(4);
            PrintAllNodes(linklist);
            //create_cycle(linklist);
            bool retCyclic = isCyclic(linklist);
          
        }

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
   
    }

    public class Node
    {
        public int value;
        public Node Next;
    }
}
