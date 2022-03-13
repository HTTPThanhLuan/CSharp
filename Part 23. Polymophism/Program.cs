using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_23.Polymophism
{
      // ####################################################################################################################
      // #                                POLYMOPHISM
      // #
      // #   1. Polymophism is one of the primary pillars of object-oriented programming 
      // #
      // #   2. Polymophism allows you to invoke derived class methods through a base class reference during runtime 
      // #
      // #   3. In The base class the method is declared virtual, and in the derived class we override the same method
      // #
      // #   4. The virtual keyword indicates, the method can be overridden in any derived class
      // #
      // ####################################################################################################################
      class Employee
      {
           
            public string FullName = "FN";
            public string LastName = "LN";
            public virtual void PrintFullName()
            {
                  Console.WriteLine("{0} {1}", FullName, LastName);
            }

      }
      class FullTimeEmployee: Employee
      {
            public override void PrintFullName()
            {
                  Console.WriteLine("{0} {1} -- FullTime", FullName, LastName);
            }
      }
      class PartTimeEmployee: Employee
      {
            public override void PrintFullName()
            {
                  Console.WriteLine("{0} {1} -- PartTime", FullName, LastName);
            }
      }
      class TemporaryEmployee: Employee
      {
            //public override void PrintFullName()
            //{
            //      Console.WriteLine("{0} {1} -- Tempolory", FullName, LastName);
            //}
      }
      class Program
      {
            static void Main(string[] args)
            {
                  //Employee[] em=new Employee[]{
                  //      new FullTimeEmployee(),
                  //      new PartTimeEmployee(),
                  //      new TemporaryEmployee()
                  //};
                  Employee[] em = new Employee[4];
                  em[0] = new Employee();
                  em[1] = new FullTimeEmployee();
                  em[2] = new PartTimeEmployee();
                  em[3] = new TemporaryEmployee();

                  foreach(var item in em)
                  {
                        item.PrintFullName();
                  }



            }
      }
}
