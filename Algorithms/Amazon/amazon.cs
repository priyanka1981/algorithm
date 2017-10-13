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
            dicSet.Add('(', ')');
            dicSet.Add('[', ']');
            dicSet.Add('{', '}');
            dicSet.Add('<','>'); 
            Stack<char> stack = new Stack<char>();
            foreach(char ch in str){
                if(dicSet.ContainsKey(ch){
                   stack.Push(ch); 
                }
                if (dicSet.ContainsValue(ch) && stack.Count > 0)
                    stack.Pop();
            }
            if (stack.Count > 0)
                return false;
            return true;
        }
    }
}
