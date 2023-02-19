using System;

namespace BuubleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 45, 89, 5, 56, 8, 78, 51, 77 };
           BubbleSort s = new BubbleSort();
            s.Sort(arr);
            s.Display(arr);
        }
    }
}
