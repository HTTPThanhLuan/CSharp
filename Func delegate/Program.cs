using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_delegate
{
      // ############################################################################################################################################################################################
      // #                                Func Delegate
      // #
      // #   What is Func<T,TResult> in C#?
      // #     
      // #   In simple terms, Func<T,TResult> is just a generic delegate, Depending on the requirement, the type parameters (T and TResult) can be replaced with the corresponding type arguments.
      // #   
      // #   For example, Func<Employee, string> is a delegate that represents a function expecting Employee object as an input parameter and returns a string
      // #   
      // #   What is difference between Func delegate and lambda expression?
      // #   They're the same, just two different ways to write the same thing. the lambda syntax is newer, more concise and easy to write
      // #   
      // #   What if i have to pass two or more input parameter?
      // #   As of this recording there are 17 overloaded versions of Func, which enables us to pass variable number and type of input parameters.
      // #   In the example below, Func<int, int, string> represents a function that expects 2 int input parameters and returns a string
      // #
      // ############################################################################################################################################################################################

      class Program
      {
            static void Main(string[] args)
            {
                  List<Employee> listEmployees = new List<Employee>(){
                        new Employee(){ ID=101, Name="Mark"},
                        new Employee(){ ID=102, Name="John"},
                        new Employee(){ ID=103, Name="Mary"},
                  };

                  //Func<Employee, string> selector = employee => "Name = " + employee.Name;

                  //IEnumerable<string> names = listEmployees.Select(selector);

                  IEnumerable<string> names = listEmployees.Select(employee => "Name = "+ employee.Name);

                  foreach(string name in names)
                  {
                        Console.WriteLine(name);
                  }

                  //############################################################

                  Func<int, int, string> funcDelegate =  (firstNumber, secondNumber) => 
                       "Sum = "+ (firstNumber + secondNumber).ToString();
                  string result=funcDelegate(10, 20);
                  Console.WriteLine(result);
            }

      }

      class Employee
      {
            public int ID { get; set; }
            public string Name { get; set; }
      }


}
