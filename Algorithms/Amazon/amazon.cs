using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
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

		public string ReversewordsCore(string str)
		{

            // Reverse the words in string eg. 'The Sky is Blue'.then print 'Blue is Sky The'.
            //HINT: use stack ;)
            Stack<string> stack = new Stack<string>();

            // each word is separated by space
            // read char by char and store it in another char builder/string builder
            // on reading space, push the contents on stack
            // now pop elements from the stack and join using space

            for (int i = 0; i < str.Length -1;i++)
            {
                stack.Push(str[i].ToString());
            }


            return null;
		}

        // find if two words ara anagrams of each other - mary and army
        public void areAnagram(String str1, String str2) {
            // HINT: use the integer array to count charactes in both the strings
        }

        // find if a string is a substring of the larger string 
        // substr - I saw a blue cat
        // largerstr - On a cloudy night I saw a blue cat jumping in the street
        public void hasSubString(String substr, String largerstr) {
            // this is done with string movement
            // traverse the larger string, and start finding chars in smaller string until you have found it all
            // if you fail to match, then move the pointer further and do the search again
        }

        // find the first duplicate character in a string
        // this is a long string: "i" is the first duplicate character
        public void printFirstDuplicateChar(String str) {
            // similar to the int array, you can use a bit array
            // set the bit to true when you find a character
            // if the bit is already true: you found first duplicate char
        }

        // find whether a string only has numbers or numbers and alphabets or numbers/alphabets/special-chars
        //123abcxyz
        //123
        //123*xyz456
        public void findPattern(String str) {
            // HINT: dont use any char traversal or hashset hashmap or anything
            if(true) {
                // print only numbers
            } else if (true) {
                // print numbers and alphabets
            } else if(true) {
                // numbers, alphabets and spcl chars
            } else {
                // none
            }
        }

        // count number of vowels and non-vowels in a string
        public void countVoewls(String str) {
            // can you take the hint from the bracket question
        }

        // MAKE THIS CLASS A SINGLETON
        // understand this -- they ask it in the interview
        public amazon getInstance(){
            return null;
        }

        // sort a file (around 100 gigs memory size) which has order numbers separated by space
        public void sortGiganticFile(File file) {
            // what can you do? would you every load this in the VM memory?
        }
	}
}
