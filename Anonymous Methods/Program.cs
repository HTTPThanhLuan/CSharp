using System;
using System.Collections.Generic;
using System.Linq;
// ####################################################################################################################
// #                                Anonymous Methods
// #
// #   What is an anonymous method?
// #     
// #   Anonymous method is a method without a name. Introduced in c#2, they provide us a way of creating delegate 
// #   instances without having to write a separate method.
// #      
// ####################################################################################################################

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
            Employee emp = listEmployees.Find
            (
                  delegate(Employee m)
                  {
                        return m.ID == 102;
                  }
            );

            Console.WriteLine("ID = {0}, Name = {1}", emp.ID, emp.Name);
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

