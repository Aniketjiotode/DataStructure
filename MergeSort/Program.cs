
using System;

namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrlist = { 45, 5, 69, 35, 6, 52, 23, 56 };
           MergeSort obj= new MergeSort();
            obj.Sort(arrlist,0,arrlist.Length-1);
            obj.Display(arrlist);

        }
    }
}
