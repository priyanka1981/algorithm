using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace Algorithms.Memorization
{
    public class PrimeNumber
    {

        //static void Main(string[] args)
        //{
        //    isPrime();
        //}

        static Dictionary<int, bool> dictonary = new Dictionary<int, bool>();
        public PrimeNumber()
        {
            
        }

       static  void isPrime()
        {
            
            while(true){
                bool result = true;
                Console.Write("Enter a Number : ");
                int num;

                DateTime dt1 = DateTime.Now;

                Stopwatch sw = new Stopwatch();
                sw.Start();

                num = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("Time when entering the method {0}", sw.Elapsed.Milliseconds);
                if (dictonary.ContainsKey(num))
                {
                    result = dictonary[num];
                    Console.WriteLine("Found the number in the cache ...");
                }
                else
                {
                    // Console.WriteLine("Time when entering the method {0}", ); 
                    for (int i = 2; i <= num / 2; i++)
                    {
                        if (num % i == 0)
                        {
                            result = false;
                            break;
                        }
                    }

                    dictonary.Add(num, result);
                }
                if (result)
                {
                    Console.WriteLine("Entered Number is a Prime Number and the Largest Factor is {0}", num);
                }
                else
                {
                    Console.WriteLine("Not a Prime Number");
                }
                DateTime dt2 = DateTime.Now;
                sw.Stop();
                Console.WriteLine("Time when exiting the method {0}", (dt2-dt1));
                //Console.ReadLine();
            }
        }

    }
}
