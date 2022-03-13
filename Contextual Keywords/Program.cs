using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contextual_Keywords
{
      class Program
      {
            static void Main(string[] args)
            {
                  foreach(var item in Foo2( 10 ))
                  {
                        Console.Write( item );
                  }

                  Console.Read();
            }

            public static IEnumerable Foo2(int number)
            {
                  for(int i = 0;i < number;i++)
                  {
                        yield return i;
                  }
            }
      }
}
