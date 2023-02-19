using System;
using System.Collections.Generic;
using System.Text;

namespace Anagram
{
    internal class CheckAnagram
    {
   
        public bool isAnagram(char[] str1, char[] str2)
        {
            if(str1.Length!=str2.Length)
            {
                return false;
            }
            Array.Sort(str1);
            Array.Sort(str2);

            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
