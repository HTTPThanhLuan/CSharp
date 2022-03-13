using System;
using System.Collections.Generic;
using System.Linq;
namespace Lambda_Expressions
{
      // ######################################################################################################################################################
      // #                                Lambda Expressions
      // #   
      // #  What are lambda expressions?
      // #     
      // #  Anonymous methods and lambda expressions are very similar. Anonymous methods were introduced in c# 2 and lambda expression in c#3 
      // #   
      // #  To find an employee with Id=102, using anonymous method
      // #  Employee employee = listEmployees.Find(delegate(Employee emp) { return emp.ID = 102 ;}); 
      // #   
      // #  To Find an employee with Id=102, using lambda expression
      // #  Employee employee =  listEmployees.Find(emp => emp.ID == 102 ); 
      // #      
      // #  You can also explicitly specify the Input type but not required 
      // #  Employee employee =  listEmployees.Find(( Employee emp) => emp.ID == 102 ); 
      // #
      // # => is called lambda operator and read as GOES TO. Notice that with a Lambda expression you don't have to use the delegate keyword explicitly and don't
      // #    have to specify the input parameter type explicitly. The parameter type is inferred. Lambda expressions are more convenient to use than anonymous methods.
      // #    Lambda expressions are particularly helpul for writing LINQ query expressions
      // #########################################################################################################################################################


      class Program
      {
            static void Main(string[] args)
            {
                  List<Employee> listEmployees = new List<Employee>(){
                  new Employee(){ ID=101, Name="Mark"},
                  new Employee(){ ID=102, Name="John"},
                  new Employee(){ ID=103, Name="Mary"},
            };

                  // Step 2
                  //Predicate<Employee> pre = new Predicate<Employee>(FindEmployee);

                  // Step 3
                  //Employee emp = listEmployees.Find(x => pre(x));

                  //###############################################################
                  //# Anonymous method
                  //Employee emp = listEmployees.Find
                  //(
                  //      delegate(Employee m)
                  //      {
                  //            return m.ID == 102;
                  //      }
                  //);
                  //###############################################################
                  //# Lambda expressions

                  //Employee emp = listEmployees.Find(x => x.ID == 102);

                  Employee emp = listEmployees.Find((Employee x) => x.ID == 102);
                  Console.WriteLine("ID = {0}, Name = {1}", emp.ID, emp.Name);

                  int count= listEmployees.Count(x => x.Name.StartsWith("M")); // System.LinQ
                  Console.WriteLine("Count = {0}",count);
            }

            // Step 1
            //static bool FindEmployee(Employee emp)
            //{
            //      return emp.ID == 102;
            //}
      }

      class Employee
      {
            public int ID { get; set; }
            public string Name { get; set; }
      }


}
