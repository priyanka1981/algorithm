using System;
namespace Algorithms.Citadel
{
    public class Citadel
    {
        public Citadel()
        {
        }

        public string NonRepeativeChar()
        {
            string str = "priyanka";
            char[] char_array = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int[] int_array = new int[25];
            foreach(char ch in str){
                int_array[ch - 'a'] += 1;
            }
            for (int i = 0; i <= int_array.Length - 1;i++)
            {
                if (int_array[i] == 1)
                    return char_array[i].ToString();
            }
            return "No non reapative string";
        }
    }
}
