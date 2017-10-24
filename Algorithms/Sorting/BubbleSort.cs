using System;
namespace Algorithms.Sorting
{
    public class BubbleSort
    {
        public BubbleSort()
        {
        }

        public void sort(int[] array)
        {
            bool swapped = false;
            do
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i+1];
                        array[i+1] = array[i];
                        array[i] = temp;
                    }
                    swapped = true;

                }
            }
            while (swapped == true);
           
        }
    }
}
