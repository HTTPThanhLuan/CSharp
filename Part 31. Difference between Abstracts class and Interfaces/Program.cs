using System;


      // ##################################################################################################################################################
      // #         Abstract classes Vs Interfaces                               
      // # 
      // # 1. Abstract classes can have implementations for some of its members(method), but the interface can't have implementation
      // #    for any its members  
      // #     
      // # 2. Interfaces cannot have fields where as an abstract class can have fields
      // #   
      // # 3. An interface can inherit from another interface only and cannot inherit from an abstract class, where as an abstract
      // #    class can inherit from another abstract class or another interface
      // #
      // # 4. A class inherit from multiple interfaces at the same time, where as a class cannot inherit from multiple classes at the same time  
      // #   
      // # 5. Abstract class members can have access modifiers where as interface members cannot have access modifiers     
      // #   
      // ###########################################################################################################################################

      class A
      {
            public virtual void Print()
            {
                  Console.WriteLine("A Implementation");
            }
      }
      class B: A
      {
            public override void Print()
            {
                  Console.WriteLine("B Implementation");
            }
      }
      class C: A
      {
            public override void Print()
            {
                  Console.WriteLine("C Implementation");
            }
      }
      //class D: B,C
      //{

      //}

      class Program
      {
            static void Main(string[] args)
            {
                 // D d=new D();
                 // d.Print(); // D class does it inherit: B, or C?
            }
      }
