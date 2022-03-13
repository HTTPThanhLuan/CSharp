using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_48.Generics
{
      class Program
      {
            static void Main(string[] args)
            {
                  // # invoke method with object parameters compiler is not error
                  // bool equal= Calculator.AreEqual("abc" , 1);

                  // # invoke generic method with T parameters compiler is error
                  //bool equal = Calculator.AreEqual<int>(3, 1);

                  // # invoke method with generic class
                  bool equal = Calculator<int>.AreEqual(3, 3);
                  

                  if(equal)
                        Console.WriteLine("Equal");
                  else
                        Console.WriteLine("Not Equal");

            }
      }

      //class Calculator
      //{
      //      //public static bool AreEqual(object value1, object value2)
      //      //{
      //      //      return value1==value2;
      //      //}

      //      public static bool AreEqual<T>(T value1, T value2)
      //      {
      //            return value1.Equals(value2);
      //      }
      //}

      class Calculator<T>
      {
            public static bool AreEqual(T value1, T value2)
            {
                  return value1.Equals(value2);
            }
      }

}
