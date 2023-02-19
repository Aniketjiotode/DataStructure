using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OrderList
{
    internal class FindNum
    {
        public sortedList<int> list = new sortedList<int>();
        
        public void GetData()
        {
            string path = @"C:\Users\91962\Desktop\binary\BinaryList.txt";
            string[] ar = new string[] {""};
            string data = File.ReadAllText(path);
            ar = data.Split(',');
            for (int i = 0; i < ar.Length; i++)
            {
                int res;
                if (int.TryParse(ar[i], out res))
                {
                    list.Add(res);
                }
            }
            
        }
    }
}
