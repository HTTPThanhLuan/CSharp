using System;
using System.Collections.Generic;


class Program
{
      static void Main(string[] args)
      {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 101, Name = "Mark", Salary = 5000, Experience = 6 });
            empList.Add(new Employee() { ID = 102, Name = "Mike", Salary = 4000, Experience = 4 });
            empList.Add(new Employee() { ID = 103, Name = "John", Salary = 3000, Experience = 5 });
            empList.Add(new Employee() { ID = 104, Name = "Todd", Salary = 6000, Experience = 3 });

            //IsPromotable isPromotable = new IsPromotable(promoted);
            //Employee.PromoteEmployee(empList, isPromotable);
            
            // using lamda exprestion
            Employee.PromoteEmployee(empList,emp=>emp.Experience>=5);
      }

      public static bool promoted(Employee em)
      {
            if(em.Experience >= 5)
                  return true;
            else
                  return false;
      }

}

public delegate bool IsPromotable(Employee employee);

public class Employee
{
      public int ID { get; set; }
      public string Name { get; set; }
      public int Salary { get; set; }
      public int Experience { get; set; }

      //public static void PromoteEmployee(List<Employee> employeeList)
      //{
      //      foreach(var employee in employeeList)
      //      {
      //            if(employee.Experience >= 5)
      //            {
      //                  Console.WriteLine(employee.Name + " Promoted");
      //            }
      //      }
      //}

      public static void PromoteEmployee(List<Employee> employeeList, IsPromotable isPromoted)
      {
            foreach(var employee in employeeList)
            {
                  if(isPromoted(employee))
                  {
                        Console.WriteLine(employee.Name + " Promoted");
                  }
            }
      }

}