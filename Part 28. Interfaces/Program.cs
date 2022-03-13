using System;
using System.Linq;

namespace Part_29.Interfaces
{
      // ###########################################################################################################################
      // #                                INTERFACES
      // #
      // #  1. We create interfaces using interface keyword. Just like classes interfaces also contains properties, methods, 
      // #     delegate or events. but only declarations and no implementations.
      // #  
      // #  2. IT IS A COMPILER TIME ERROR TO PROVIDE IMPLEMENTATIONS FOR ANY INTERFACE MEMBER.
      // #
      // #  3. Interface members are public by default, and they don't allow explicit access modifiers.
      // #     
      // #  4. INTERFACE CAN'T CONTAIN FIELDS.
      // #   
      // #  5. If a class or a struct inherits from an interface, it must provide implementation for all interface members.
      // #     Otherwise, we get a compiler error
      // #  
      // #  6. A CLASS OR A STRUCT CAN INHERIT FROM MORE THAN ONE INTERFACE AT THE SAME TIME. BUT WHERE AS, A CLASS CANNOT INHERIT
      // #     FROM MORE THAN ONCE CLASS AT THE SAME TIME
      // #  
      // #  7. Interfaces can inherit from other interfaces. A class that inherits this interface must provide implementation
      // #     for all interface members in the entire inheritance chain
      // #
      // #  8. WE CANNOT CREATE AN INSTANCE OF AN INTERFACE, BUT AN INTERFACE REFERENCE VARIABLE CAN POINT TO A DERIVED CLASS OBJECT
      // #
      // #  Interface Naming Convention: Interface names are prefixed with capital I.
      // ###########################################################################################################################


      interface ICustomer
      {
            // wrong with 2
            //void Print() 
            //{
            //      Console.WriteLine("ICustomer");
            //}
            
            
            // wrong with 3
            // public void Print();

            
            // Wrong with 4
            // int ID;


            void Print();
      }

      class LocalCustomer:ICustomer
      {

            public void Print()
            {
                  Console.WriteLine("LocalCustomer");
            }
      }
      class ForeignCustomer : ICustomer
      {
            public void Print()
            {
                  Console.WriteLine("ForeignCustomer");
            }
      }
      class Program
      {
            static void Main(string[] args)
            {
                  ICustomer myLCustomer=new LocalCustomer();
                  myLCustomer.Print();

                  ICustomer myFCustomer = new ForeignCustomer();
                  myFCustomer.Print();
         
            }
      }
}
