using System;

namespace Algorithms
{
    class Program
    {
       // static void Main(string[] args)
        //{
          //  Citadel();
       // }

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

        static void General()
        {
            Algorithms.General.General generalClass = new Algorithms.General.General();
            /*  int n = Convert.ToInt16(Console.ReadLine());
			 int factorail = generalClass.Factorial(n);
			 Console.WriteLine("Factorial of {0} is {1}" ,n , factorail.ToString());
			 int factorial_nonrec = generalClass.Factorial_NonRec(n);
			 Console.WriteLine("Factorial of {0} is {1}", n, factorial_nonrec.ToString());
			 int fib = generalClass.Fibonnaci(n);
			 Console.WriteLine("Fibonnaci series result {0} ", fib.ToString());
			 int fib_nonRec = generalClass.Fibonnaci_Nonrec(n);
			 Console.WriteLine("Fibonnaci series result {0} ", fib_nonRec.ToString());
			 string str = Console.ReadLine();
			 bool retbool = generalClass.palindrome(str);
			 Console.WriteLine("Palindrome series result {0}", retbool);
			   string[] array ={"civic","deified","deleveled","devoved","dewed",
				"Hannah",
				"kayak",
				"level",
				"madam",
				"racecar",
				"radar",
				"redder",
				"refer",
				"repaper",
				"reviver",
				"rotator",
				"rotor",
				"sagas",
				"solos",
				"sexes",
				"stats",
				"tenet","Dot",
				"Net",
				"Perls",
				"Is",
				"Not",
				"A",
				"Palindrome",
				""
				};

				foreach (string value in array)
				{
					Console.WriteLine("{0} = {1}", value, generalClass.palindrome(value));

				}*/ 
            string stringToReverse = Console.ReadLine();
            string strReverse = generalClass.Reverse(stringToReverse);
            Console.WriteLine("Reverse String is {0}",strReverse);
		}

        static void Amazon()
        {
			Algorithms.Amazon.amazon amazon = new Algorithms.Amazon.amazon();

			/* bool retbool = amazon.isBalanceBraces(str);
			 Console.WriteLine("is string is balance {0}", retbool.ToString());*/
			string str = Console.ReadLine();
            // string countstring = amazon.CountAlphabets(str);
            // Console.WriteLine("Count of string {0}", countstring);
            //string reverseword = amazon.Reversewords("The sky is blue");
            //Console.WriteLine("Reverse wwords is {0}", reverseword);
            //string reverse = amazon.ReversewordsCore("The Sky is Blue");
            // bool ret = amazon.areAnagram("abc","cbz");
            // Console.WriteLine("Are Anagram {0}", ret.ToString());
            // bool retIsSub = amazon.hasSubString("I saw a blue cat","On a cloudy night I see I saw a blue cat jumping in the street");
            // Console.WriteLine("Has Substring {0}", retIsSub.ToString());
            Console.WriteLine("First duplicate {0}", amazon.printFirstDuplicateChar(str));
        }

        static void CrakingCode()
        {
            Algorithms.CrakingThecoding.CrakingCode craking = new CrakingThecoding.CrakingCode();
            craking.Permutation("abc");
            bool ret = craking.UniqueChar("priyanka");
        }

        static void sort()
        {
            Algorithms.Sorting.BubbleSort bubblesort = new Sorting.BubbleSort();
            int[] nums = { 5, 10, 3, 2, 4 };
            bubblesort.sort(nums);
        }

        static void Citadel()
        {
            Algorithms.Citadel.Citadel citadel = new Algorithms.Citadel.Citadel();
            string str=  citadel.NonRepeativeChar();
            Console.Write("First non repeative char {0}", str); 
        }

      
		
    }
}
