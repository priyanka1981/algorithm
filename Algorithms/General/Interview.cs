using System;
using System.Collections.Generic;
namespace Algorithms.General
{
    public class Interview
    {
        public Interview()
        {
        }

        static void Main(string[] args)
        {
            FindUnsortedArrayMaxOccrance();
        }

        static  void FindUnsortedArrayMaxOccrance()
        {
            int[] array = { 1,1,1,1,1,1,5,10,10,10,10 };
            int max = 0;

            foreach(int num in array)
            {
                if (num > max) max = num;
            }
            int[] max_Occurance_array = new int[max+1];
            foreach(int num in array)
            {
                max_Occurance_array[num] += 1;
            }
            int index_max = 0;
            int max_occurance_count = 0;
            for (int i = 0; i <= max_Occurance_array.Length-1;i++)
            {
                if (max_Occurance_array[i] > max_occurance_count)
                {
                    index_max = i;
                    max_occurance_count = max_Occurance_array[i];
                }
            }
            int max_num = max_Occurance_array[index_max];

        }

        static void cycle_single_linklist()
        {
            LinkedList<int> link_list = new LinkedList<int>();
            link_list.
        }
    }
}
