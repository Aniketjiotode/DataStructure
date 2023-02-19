using System;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
           BinarySort s = new BinarySort();
            string[] list=s.GetData();
            string f = "Rajat";
            var ind=s.binarySearch(list, f);
            Console.WriteLine($"Word is Present At {ind} index");
        }
    }
}
