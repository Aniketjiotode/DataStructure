using System;
using System.Collections.Generic;
using System.Text;


namespace Stack_
{
    class Balanace_Parentheses
    {
        public  void checkBalance()
        {
            Console.Write("Enter Arithmetic Equation: ");
            string Str = Console.ReadLine();
            Console.WriteLine(Balanced(Str));
        }
        public  bool Balanced(string s)
        {
            Stack <Char> stack = new Stack<Char>(s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                char chars = s[i];
                if (chars == '(')
                {
                    stack.Push(chars);
       
                }
                else
                {
                    if (chars == ')' && stack.Pop() != '(')
                    {
                        return false;
                    }
                }
            }

            return stack.IsEmpty();

        }
    }
}