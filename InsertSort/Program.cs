using System;

namespace Insertion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 45, 89, 36, 78, 21, 22, 87 };
            InsertionSort s = new InsertionSort();
            s.sort(list);
            s.Display(list);
        }
    }
}
