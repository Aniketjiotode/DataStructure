using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BinarySearch
{
    internal class BinarySort
    {
        public int binarySearch(string[] arr, string x)
        {
            int l = 0, h = arr.Length - 1;
            while (l <= h)
            {
                int m = l + (h - l) / 2;

                int res = x.CompareTo(arr[m]);

                if (res == 0)
                    return m;

                if (res > 0)
                    l = m + 1;

                else
                    h = m - 1;
            }

            return -1;
        }
        public string[] GetData()
        {
            string path = @"C:\Users\91962\Desktop\binary\BinaryList.txt";
            string[] ar = new string[] {""}; 
            string data =  File.ReadAllText(path);
            ar = data.Split(',');
             Array.Sort(ar);
            return ar;
        }
    }
}
