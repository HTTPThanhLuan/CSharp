using System;
using System.Collections.Generic;


class MainClass
{
      static void Main(string[] args)
      {
            // Caculator.Add(1,3);
            // Caculator.Add(new List<int>() { 1,2,3});
      }
}

class Caculator
{
      [Obsolete("User Add(List<int> numbers) Method")]
      internal static int Add(int FN, int SN)
      {
            return FN+SN;
      }
      internal static int Add(List<int> numbers)
      {
            int sum=0;
            foreach(int n in numbers)
            {
                  sum+=n;
            }
            return sum;
      }
}
