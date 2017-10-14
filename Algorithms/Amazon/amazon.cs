using System;
using System.Collections.Generic;
using System.Text;
namespace Algorithms.Amazon
{
    public class amazon
    {
        public amazon()
        {
        }

        public bool isBalanceBraces(string str)
        {
            
            Dictionary<char, char> dicSet = new Dictionary<char,char>();
            dicSet.Add(')', '(');
            dicSet.Add(']', '[');
            dicSet.Add('}', '{');
            dicSet.Add('>','<');
            HashSet<char> hashset = new HashSet<char>();
            hashset.Add('(');
            hashset.Add('[');
            hashset.Add('{');
            hashset.Add('<');
            Stack<char> stack = new Stack<char>();
            foreach(char ch in str){
                if(hashset.Contains(ch)){
                   stack.Push(ch); 
                }
                else if(dicSet.ContainsKey(ch))
                {
                    char retChar = stack.Peek();

                    //char ch_open = dicSet[ch];

                    if (retChar == dicSet[ch])
                        stack.Pop();
                }
            }
            if (stack.Count > 0)
                return false;
            return true;
        }

        public string CountAlphabets(string str)
        {
            int[] array = new int[25];
            foreach(char ch in str){
                array[ch-'a'] += 1;
            }
            StringBuilder retstr = new StringBuilder();
            for (int i = 0; i < 25;i++)
            {
                if (array[i] > 0)
                {
                    char chr = Convert.ToChar('a' + i);
                    retstr.Append(chr.ToString()+array[i]);
                }
            }

            return retstr.ToString();

        }

        public string Reversewords(string str)
        {

            // Reverse the words in string eg. 'The Sky is Blue'.then print 'Blue is Sky The'.
           string[] array = str.Split(' ');
            StringBuilder retstring = new StringBuilder();
            for (int i = array.Length-1; i >=0;i--)
            {
                retstring.Append(array[i].ToString() + " ");
            }
            return retstring.ToString();
        }


	}
}
