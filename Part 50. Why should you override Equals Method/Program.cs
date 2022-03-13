using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_50.Why_should_you_override_Equals_Method
{
      class Program
      {
            static void Main(string[] args)
            {
                  //####################################################################
                  //#                         Value Type
                  int i = 10;
                  int j = 10;

                  //Console.WriteLine(i == j);
                  //Console.WriteLine(i.Equals(j));


                  Direction direction1 = Direction.East;
                  Direction direction2 = Direction.North;

                  //Console.WriteLine(direction1 == direction2);
                  //Console.WriteLine(direction1.Equals(direction2));


                  Student st1 = new Student() { FN = "Luan", LN = "Tran" };
                  Student st2 = new Student() { FN = "Luan", LN = "Tran1" }; ;

                  //Console.WriteLine(st1 == st2);
                  //Console.WriteLine(st1.Equals(st2));

                  //####################################################################
                  //#                         Reference Type



                  Customer cs1 = new Customer() { FN = "Luan", LN = "Tran" };
                  // Customer cs2=cs1;
                  Customer cs2 = new Customer() { FN = "Luan", LN = "Tran" };
                  Console.WriteLine(cs1.GetHashCode());
                //  Console.WriteLine(cs1 == cs2);
               //   Console.WriteLine(cs1.Equals(cs2));
            }
      }

      public enum Direction
      {
            East = 1,
            West = 2,
            North = 3,
            South = 4
      }
      struct Student
      {
            public string FN;
            public string LN;
      }

      public class Customer
      {
            public string FN;
            public string LN;
            public override bool Equals(object obj)
            {
                 // return base.Equals(obj);
                  if(obj ==null) 
                  {
                        return false;
                  }

                  if(!(obj is Customer))
                  {
                        return false;
                  }

                  return this.FN == ((Customer)obj).FN && 
                        this.LN == ((Customer)obj).LN;

            }
            public override int GetHashCode()
            {
                  //return base.GetHashCode();
                 Console.WriteLine(this.FN.GetHashCode() ^ this.LN.GetHashCode());
                  return 1;
                  //return this.FN.GetHashCode() ^ this.LN.GetHashCode();
            }

      }
}
