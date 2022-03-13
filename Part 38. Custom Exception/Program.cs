using System;
using System.Collections.Generic;
      // ####################################################################################################################
      // #                                CUSTOM EXCEPTION
      // #
      // #  To understand custom exceptions. you should have good understanding of
      // #     
      // #  When do you usually go for creating your own custom exception?
      // #   
      // #  If none of the already existing dotnet exceptions adequately describes the problem. 
      // #      
      // #  Example:
      // #  1. I have an asp.net web application.
      // #  2. The application should allow the user to have only one logged in session.
      // #  3. If the user is already logged in, and if he opens another browser window and tries to login again, the application 
      // #     should throw an error stating he is already logged in another browser window.
      // #      
      // #   With in the .NET framework we don't have any exception, that adequately describes this problem. So this scenario is
      // #   one of the examples where you want to create a custom exception.
      // #
      // # 1. Create a class that derives from System.Exception class. As a convention, end the class name with Exception suffix.
      // #    All .NET exceptions end with, exception suffix.
      // #
      // # 2. Privide a public constructor, that takes in a string parameter. This constructor simply passes the string parameter,
      // #    to the base exception class constructor.
      // #
      // # 3. Using innerExceptions, you can also track back the orginal exception. If you want to provide this capability for your 
      // #    custom exception class, then overload the constructor accordingly.
      // #
      // # 4. If you want your Exception class object to work across application domains, then the object must be serializable. To
      // #    make your exception class serializable mark it with serializable attribute and provide a constructor that invokes
      // #    the base Exception class constructor that takes is SerializationInfo and StreamingContext objects as parameters.
      // #
      // # NOTE: It is also possible to provide your own custom serialization, which will discuss in a later session
      // #
      // ####################################################################################################################

class CustomException
{
      static void Main(string[] args)
      {
        throw new MyException();    
      }
}

[Serializable]
public class MyException: Exception
{
      public MyException() { }
      public MyException(string message) : base(message) { }
      public MyException(string message, Exception inner) : base(message, inner) { }
      protected MyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
}
