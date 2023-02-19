using System;
using System.Collections.Generic;
using System.Text;

namespace BuubleSort
{
    internal class BubbleSort
    {
        public void Sort(int[] arr)
        {
            int size = arr.Length;
            for (int i = 0; i < size - 1; i++)
                for (int j = 0; j < size - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
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
