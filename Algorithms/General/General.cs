using System;
namespace Algorithms.General
{
    public class General
    {
        public General()
        {
        }

        public int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        public int Factorial_NonRec(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
            {
                int result = 1;
                for (int i = n; i >=1; i--)
                {
                    result = result * i;
                }
                return result;
            }
        }

        public int Fibonnaci(int n)
        {
            if (n <=2)
                return 1;
            else
                return Fibonnaci(n - 1) + Fibonnaci(n-2);
        }

        public int Fibonnaci_Nonrec(int n)
        {
           
			int fib0 = 0, fib1 = 1;
			for (int i = 2; i <= n; i++)
			{
				int tmp = fib0;
				fib0 = fib1;
				fib1 = tmp + fib1;
			}
            return (n > 0 ? fib1 : 0);
        }

        public bool palindrome(string str)
        {
            int min = 0;
            int max = str.Length - 1;
            while(max>=min)
            {
                if(str[min] != str[max])
                {
                    return false;
                }
				min++;
				max--;
            }
            return true;
        }
    }
}
