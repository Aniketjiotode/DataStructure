using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNum_Range
{
    internal class PrimeNumWithCondition
    {
        public List<int> primeList = new List<int>();
        public List<string> AnagramList = new List<string>();
        public List<int> palindromeList = new List<int>();


        public  void printAllAnagram(List<int> list, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    string str1 = list[i].ToString();
                    string str2 = list[j].ToString();
                    if (isAnagram(str1, str2))
                    {
                        AnagramList.Add("   {" + str1 + " is anagram of " + str2 + "}   ");
                    }
                }
            }
            Console.WriteLine("\nprime Anagram");
            foreach(var a in AnagramList)
            {
                Console.Write(a+" ");
            }

        }
        public static bool isAnagram(string string1, string string2)
        {
            if (string1.Length != string2.Length)
                return false;
            char[] array1 = string1.ToCharArray();
            Array.Sort(array1);
            char[] array2 = string2.ToCharArray();
            Array.Sort(array2);
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isPalindrome(int num)
        {
            int num1 = num;
            int rev = 0;
            for (int rem; num1 != 0; num1 = num1 / 10)
            {
                rem = num1 % 10;
                rev = rev * 10 + rem;
            }
            if (num == rev)
                return true;
            else
                return false;
        }

         public void palindromePrint()
        {
            for (int i = 0; i < primeList.Count; i++)
            {
                if (isPalindrome(primeList[i]))
                {
                    palindromeList.Add(primeList[i]);
                }
            }
            Console.WriteLine("\nprime palindrome");
            foreach (var a in palindromeList)
            {
                Console.Write(a +" ");
            }
         
        }
        public static bool isPrime(int num)
        {
          
            if (num == 0 || num == 1)
                return false;
            for (int i = 2; i <= num / 2; ++i)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public  void primePrint()
        {
            Console.WriteLine("Prime numbers are in between " + 0 + " and " + 1000 + " are :");
            for (int i=0; i <= 1000; i++)
            {
                if (isPrime(i))
                {
                    primeList.Add(i);
                }
            }
            Console.WriteLine("\nprime");
            foreach (var a in primeList)
            {
                Console.Write(a+" ");
            }

        }
    }

}
