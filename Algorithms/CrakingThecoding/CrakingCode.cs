using System;
namespace Algorithms.CrakingThecoding
{
    public class CrakingCode
    {
        public CrakingCode()
        {
        }

        public bool UniqueChar(string str)
        {
            int[] array = new int[25];
            foreach (char ch in str)
            {
                if (array[ch-'a'] == 1)
                    return false;
                array[ch - 'a'] = 1;
            }
            return true;
        }
    }
}
