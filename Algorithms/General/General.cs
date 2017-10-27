using System;
using System.Text;
using System.Collections.Generic;
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
                for (int i = n; i >= 1; i--)
                {
                    result = result * i;
                }
                return result;
            }
        }

        public int Fibonnaci(int n)
        {
            if (n == 0)
                return 0;
             else if (n < 2)
                return 1;
            else
                return Fibonnaci(n - 1) + Fibonnaci(n - 2);
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
        {//abc cba
            int min = 0;
            int max = str.Length - 1;
            while (max >= min)
            {
                if (str[min] != str[max])
                {
                    return false;
                }
                min++;
                max--;
            }
            return true;
        }

        public string Reverse(string str)
        {
            //Reverse this string 1 + 2 * 3 - 20.Note: 20 must be retained as is.
            //Expected output: 20 - 3 * 2 + 1
            StringBuilder result = new StringBuilder();
            HashSet<string> operator_set = new HashSet<string>();
            operator_set.Add("+");
            operator_set.Add("-");
            operator_set.Add("*");
            operator_set.Add("/");
            operator_set.Add("%");
            //string[] operator_list = { "+", "*", "%", "/", "-" };
            Stack<string> stack = new Stack<string>();
            StringBuilder strneww = new StringBuilder();
            for (int i = 0; i <= str.Length - 1; i++)
            {
                int retNum;
                if (int.TryParse(str[i].ToString(), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum))
                {
                    strneww.Append(str[i].ToString());
                }

                /* if (!string.IsNullOrEmpty(str[i + 1].ToString()) && operator_set.Contains(str[i+1].ToString())
				 {
					 strneww.Append(str[i].ToString());

				 }*/
                if (operator_set.Contains(str[i].ToString()) || i == str.Length - 1)
                {
                    stack.Push(strneww.ToString());
                    strneww.Clear();
                }
                if (operator_set.Contains(str[i].ToString()))
                    stack.Push(str[i].ToString());
            }
            foreach (string sh in stack)
            {
                result.Append(sh);
            }
            return result.ToString();

        }

        public string isAnagram(string str1, string str2)
        {
            if (str1.Length != str1.Length)
                return "Strings are not Anagram";
            else
            {
                int[] array = new int[25];
                foreach (char ch in str1)
                {
                    array[ch - 'a'] += 1;
                }
                foreach (char chr in str2)
                {

                    array[chr - 'a'] -= 1;
                }
                foreach (int bol in array)
                {
                    if (bol > 0 || bol < 0)
                        return "strings are not Anagram";

                }
            }
            return "Strings are not Anagram";
        }

        public void swapInteger(int i, int j)
        {
            i = i + j;
            j = i - j;
            i = i - j;

        }

        public void findPairSumToValue(int target)
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 2 };
            List<string> pair = new List<string>();
            for (int i = 0; i <= array.Length-1;i++ )
            {
                for (int j = 0; j <= array.Length-1; j++)
                {
                    if (i != j)
                    {
                        int sum = array[i] + array[j];
                        if (target == sum)
                        {
                            pair.Add("{" + array[i] + ", " + array[j] + "}");
                        }
                    }
                }
            }
        }
       public  int SparseBitcount(int n)
        {
            int count = 0;
            while (n != 0)
            {
                count++;
                n &= (n - 1);
            }
            return count;
        }

}

}
