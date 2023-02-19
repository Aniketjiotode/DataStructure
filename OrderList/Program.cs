using System;
using System.Collections.Generic;

namespace OrderList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number u want to find");
            int n = int.Parse(Console.ReadLine());
            FindNum f = new FindNum();  
            f.GetData();
            f.list.Search(n);
            if (!f.list.Search(n))
            {
                Console.WriteLine("Enter number  not found and Added to list");
                f.list.Add(n);
                Console.WriteLine(f.list.ToString());
            }
            else
            {
                Console.WriteLine($"Number found at {f.list.Index(n)} index");

            }

        }
    }
}
