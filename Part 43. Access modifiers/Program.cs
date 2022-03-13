using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_43.Access_modifiers
{
      // ######################################################################################################################################################################
      // #                                Private, public & protected
      // #
      // #   Access Modifier                                       Accessibility
      // #     
      // #   Private  (Default for type members)                   Only with in the containing class
      // #   
      // #   Public                                                Any Where, No Restrictions   
      // #   
      // #   Protected                                             With in the containing types and the types derived from the containing type
      // #   
      // #   internal  (Default for types)                          Anywhere with in the containing assembly
      // #      
      // #   Protected internal                                    Anywhere with in the containing assembly, and from within a derived class in any other assembly
      // #
      // #####################################################################################################################################################################


      public class Customer
      {
            private string Name;
            protected int ID;
            
            public void Print()
            {
                  Console.WriteLine("Name= {0} && ID={1}",Name,ID);
            }
      }
      public class A: Customer
      {
            public void Print()
            {
                A a=new A();
                a.ID=102;
               
                //  this.ID=1;
                //  base.ID;
            }
      }
      class Program
      {
            static void Main(string[] args)
            {
                  //A cs=new A();
                  //cs.ID; // Can't access bacause Program class doesn't derived from Customer
            }
      }
}
