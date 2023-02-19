using System;

namespace Anagram
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter two to check Anagram");
            Console.WriteLine("Enter string1");
            string S1 = Console.ReadLine();
            Console.WriteLine("Enter string2");
            string S2 = Console.ReadLine();
            char[] Str1 = S1.ToCharArray();
            char[] Str2 = S2.ToCharArray();       
            CheckAnagram anagram = new CheckAnagram();

            if (anagram.isAnagram(Str1, Str2))
            {
                Console.WriteLine("Given string are Anagram");
            }
            else
            {
                Console.WriteLine("Given string  are not Anagram");
            }
        }
    }
    
}      


