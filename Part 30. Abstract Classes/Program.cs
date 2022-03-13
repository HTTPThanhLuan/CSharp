using System;

      // ####################################################################################################################
      // #                                ABSTRACT CLASSES
      // # 1. The abstract keyword is used to create abstract class
      // # 
      // # 2. An abstract class is incomplete and hence cannot be instantiated
      // # 
      // # 3. An abstract class can only be used as base class    
      // # 
      // # 4. An abstract class cannot be sealed.  
      // # 
      // # 5. An abstract class may contain abstract members ( methods, properties, indexers, and events), but not mandatory
      // # 
      // # 6. A non-abstract class derived from an abstract class must provide implementations for all inherited abstract members.  
      // #
      // # If a class inherit an abstract class. There are 2 options available for that class.
      // #
      // # Option 1: Provide implementation for all the abstract members inherited from the base abstract class.
      // #
      // # Option 2: If the class does not wish to provide implementation for all the abstract members inherited from the abstract class,
      // #           then the class has to be marked as abstract.
      // ####################################################################################################################

      abstract class AB1
      {
            public abstract void Print1();
            public int ID
            {
                  get;set;
            }
            public void Print3()
            {
                  Console.WriteLine("Print 3");
            }
      } 
      abstract  class AB2: AB1
      { 
          public abstract void Print2();

      }
      class Program: AB2
      {
            //public override void Print()
            //{
            //      Console.WriteLine("Print");
            //      //throw new NotImplementedException();
            //}
            
            static void Main(string[] args)
            {
                  Program p=new Program();
              
                  
            }
            public override void Print2()
            {
                  throw new NotImplementedException();
            }

            public override void Print1()
            {
                  throw new NotImplementedException();
            }
      }
