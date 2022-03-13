using System;
using System.IO;

// ####################################################################################################################
// #                                INNER EXCEPTION
// #
// #   The InnerException property returns the Exception instance that caused the current exception 
// #     
// #   To retain the original exception pass it as a parameter to the constructor, of the current exception
// #   
// #   Always check if inner exception is not null before accessing any property of the inner exception object, else   
// #   you may get Null Reference Exception
// #  
// #   To get the type of InnerException use GetType() method. 
// #   
// #      
// #   
// #
// ####################################################################################################################

class InnerException
{
      static void Main(string[] args)
      {
            try
            {
                  try
                  {
                        Console.WriteLine("Enter first Number");
                        int FN = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Second Number");
                        int SN = Convert.ToInt32(Console.ReadLine());

                        int result = FN / SN;
                        Console.WriteLine("Result = {0}", result);
                  }
                  catch(Exception ex)
                  {
                        string filePath = @"C:\folder\data1.txt";
                        if(File.Exists(filePath))
                        {
                              StreamWriter sw = new StreamWriter(filePath);
                              sw.Write(ex.GetType().Name);
                              sw.Write(ex.Message);
                              sw.Close();
                              Console.WriteLine("There is a problem, please try later");
                        }
                        else
                        {
                              //throw new FileNotFoundException(filePath + "is not present",ex);
                              throw new FileNotFoundException(filePath + "is not present");
                        }
                  }
            }
            catch(Exception ex)
            {
                  Console.WriteLine("Current Exception = {0}", ex.GetType().Name);
                  if(ex.InnerException != null) //Always check if inner exception is not null
                  Console.WriteLine("Current Exception = {0}", ex.InnerException.GetType().Name);
            }
           
            

      }
}
