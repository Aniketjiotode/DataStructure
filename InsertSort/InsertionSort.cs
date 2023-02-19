using System;
using System.Collections.Generic;
using System.Text;

namespace Insertion
{
    internal class InsertionSort
    {
        public void sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int F = arr[i];
                int R = i - 1;
                while (R >= 0 && arr[R] > F)
                {
                    arr[R + 1] = arr[R];
                    R = R - 1;
                }
                arr[R + 1] = F;
            }
        }
        public void Display(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
