using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon
{
      class Program
      {
            static void Main(string[] args)
            {
                  int number = 10;
                  Console.WriteLine(number.ToString());

                  // Custom type

                  Customer c1 = new Customer { FN = "Simon", LN = "Tan" };

                 // Console.WriteLine(c1.ToString()); // Return "Simon.Cusomer" if you don't overrite ToString method.
                  Console.WriteLine(c1.ToString());
                  Console.WriteLine(Convert.ToString(c1));

            }
      }

      class Customer
      {
            public string FN { get; set; }
            public string LN { get; set; }
            public override string ToString()
            {
                 // return base.ToString();
                  return this.FN +", "+ this.LN;
            }

      }
}
