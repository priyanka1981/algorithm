using System;
using System.Text;
using System.Collections.Generic;
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

        public void Permutation(string str)
        {
            //abc
            List<string> permlst = new List<string>();
            for (int i = 0; i <= str.Length - 1;i++)
            {
                StringBuilder strBuilder = new StringBuilder();
                for (int j = 1; j <= str.Length - 1;j++)
                {
                    strBuilder.Append(str[i].ToString() + str[j].ToString());
                    for (int k = j+1; k <=str.Length - 1; k++)
                    {
                        strBuilder.Append(str[k]);
                    }
                    permlst.Add(strBuilder.ToString());
                    strBuilder.Clear();
                }
            }
        }
    }
}
