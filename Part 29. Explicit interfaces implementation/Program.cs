using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_interfaces_implementation
{
      // ####################################################################################################################
      // #                                EXPLICIT INTERFACE IMPLEMENTATION
      // #
      // # Question: A class inherits from 2 interfaces and both the interfaces have the same method name. How should the class
      // #           implement the method for both the interfaces?
      // # 
      // #  WE ARE USING EXPLICIT INTERFACE IMPLEMENTATION TECHNIQUE TO SOLVE THIS PROBLEM
      // # 
      // #  NOTE: 
      // #   1. When a class explicitly implements, an interface member, the interface can no longer be accessed thru class 
      // #      reference variable, but only thru the interface reference variable
      // #   
      // #   2. Access modifiers are not allowed on explicitly implemented interface members
      // # 
      // #   3. If you want to make one of the interface method, the default, then implement that method normally and the other
      // #      interface method explicitly. This makes the default method to be accessible thru class instance
      // #
      // ####################################################################################################################

      interface I1
      {
            void interfaceMethod();
      }
      interface I2
      {
            void interfaceMethod();
      }


      class Program:I1,I2
      {
            static void Main(string[] args)
            {
                  Program p=new Program();

                  // Note 1
                  ((I1) p).interfaceMethod();
                  ((I2) p).interfaceMethod();

                  // p.interfaceMethod(); // We cannot do this

                  // Note 3
                  // p.interfaceMethod();

                
            }

            //#########################################################################
            //#                          NOTE 1
            //void I1.interfaceMethod()
            //{
            //      Console.WriteLine("I1 Interface Method");
            //}
            //void I2.interfaceMethod()
            //{
            //      Console.WriteLine("I2 Interface Method");
            //}

            ///#########################################################################
            //#                          NOTE 2 
            //public void I1.interfaceMethod() 
            //{
            //      Console.WriteLine("I1 Interface Method");
            //}

            

            //#########################################################################
            //#                          NOTE 3
            public void interfaceMethod()
            {
                  Console.WriteLine("I1 Interface Method");
            }
            void I2.interfaceMethod()
            {
                  Console.WriteLine("I2 Interface Method");
            }
           
      }
}
