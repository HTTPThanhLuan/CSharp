using System;
using System.IO;
class ExceptionHandling
{
       // ####################################################################################################################
      // #                               EXCEPTION HANDLING
      // # An exception is an unforeseen error that occurs when a program is running
      // #
      // # Examples:
      // # Trying to read from a file that does not exist, throws FileNotFoundException.
      // # Trying to read from a database table that does not exist, throws a SqlException.    
      // #   
      // #  Showing actual unhandled exceptions to the end use is bad for two reasons. 
      // #      
      // #  1. Users will be annoyed as they are cryptic and does not make much sense to the end users.
      // #
      // #  2. Exceptions contain information, that can be used for hacking into your application
      // #   
      // #  AN EXCEPTION IS ACTUALLY A CLASS THAT DERIVED FROM SYSTEM.EXCEPTION CLASS. THE SYSTEM.EXCEPTION CLASS HAS SEVERAL 
      // #  USEFUL PROPERTIES, THAT PROVIDE VALUABLE INFORMATION ABOUT THE EXCEPTION.  
      // #
      // #  Message: Gets a message that describle the current exception
      // #  Stack Trace: Provides the call stack to the line number in the method where the exception occurred
      // #
      // #  We use try, catch and finally blocks for exception handling:
      // #  try- The code that can possibly cause an exception will be in the try block
      // #  catch- Handles the exception
      // #  Clean and free resources that the class was holding onto during the program execution. Finally block is optional
      // #
      // # NOTE: It is a good practice to always release resuorces in the finally block, because finally block is guaranteed
      // #       to execute, irrespective of whether there is an exception or not.
      // #
      // # Specific exceptions will be caught before the base general exception, so specific exception blocks should aways be
      // # on top of the base exception block. Otherwise, you will encounter a compiler error
      // #
      // ####################################################################################################################

      static void Main(string[] args)
      {
            StreamReader streamReader=null;
            try
            {
                  streamReader=new StreamReader(@"C:\folder1\data.txt");
                  Console.WriteLine(streamReader.ReadToEnd());
                 
            }
            catch(FileNotFoundException ex)
            {
                  // Log the details to the DB
                 Console.WriteLine("Please check if the file {0} exists",ex.FileName);
            }
            catch(Exception ex)
            {
                  Console.WriteLine(ex.Message);
            }
            finally
            {
                  if(streamReader!=null)
                        streamReader.Close();
                  Console.WriteLine("Finally Block");
            }
         
      }
}

