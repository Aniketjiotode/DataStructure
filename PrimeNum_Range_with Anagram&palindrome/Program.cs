using System;

namespace PrimeNum_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
          PrimeNumWithCondition p = new PrimeNumWithCondition();
            p.primePrint();
            p.printAllAnagram(p.primeList,p.primeList.Count);
            p.palindromePrint();

        }
    }
}
