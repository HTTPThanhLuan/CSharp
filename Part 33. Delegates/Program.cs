using System;

// ####################################################################################################################
// #                                DELEGATE
// #
// #   1. A delegate is a type safe function pointer. That is, it holds a reference(Pointer) to a function
// #     
// #   2. The signature of the delegate must match the signature of the function, the delegate points to, otherwise you
// #      you get a compiler error. This is the reason delegates are called as type safe funcion pointers.
// #   
// #   3. A delegate is similar to a class. You can create an instance of it, and when you do so. you pass in the function name   
// #      as a parameter to the delegate constructor. and it is to this function the delegate will point to.
// #
// #   TIP TO REMEMBER DELEGATE SYNTAX: Delegate syntax look very much similar to a method with a delegate keyword
// #   
// #      
// #   
// #
// ####################################################################################################################

public delegate void HelloFunctionDelegate(string Message);

class Program
{
      static void Main(string[] args)
      {
            HelloFunctionDelegate del=new HelloFunctionDelegate(Hello);
            del("Hello From Delegate");
      }

      public static void Hello(string Message)
      {
            Console.WriteLine(Message);
      }
}

