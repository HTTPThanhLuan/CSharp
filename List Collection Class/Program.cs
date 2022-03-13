using System;
using System.Collections.Generic;
using System.Linq;

// ####################################################################################################################
// #                                List Collection Class
// #
// #   List is one of the generic collection classes present in System.Collections.Generic namespace. There are several
// #   generic collection classes in System.Collection.Generic namespace as listed below.  
// #   
// #   1. Dictionary - Discussed in Parts 72 & 73
// #      
// #   2. List
// #
// #   3. Stack
// #   
// #   4. Queue etc   
// #   
// #   A List class can be used to create a collection of any type.
// #   
// #   For example, we can create a list of Integers, Strings and even complex types.
// #   
// #   The objects stored in the list can be accessed by index.
// #   
// #   Unlike arrays, lists can grow in size automatically
// #
// #   This class also provides methods to search, sort, and manipulate lists.
// #
// #   Some function
// #
// #   1. Contains() function - Checks if an item exists in the list. This mothed returns true if the items exists, else alse
// #  
// #   2. Exists() function - Checks if an item exists in the list based on a condition. This method returns true if the items exists, else false
// #
// #   3. Find() function -  Searches for an element that matches the conditions defined by the spectified lambada expression and returns the first matching item from the list
// #
// #   4. FindLast() function - Searches for an element that matches the conditions defined by the specified lambda expression and returns the Last matching item from the list
// #
// #   5. FindAll() function -  Returns all the items from the list that match the conditions specified by the lambda expression
// #
// ################################################################################################################################

class Program
{
      static void Main(string[] args)
      {
            Customer customer1 = new Customer()
            {
                  Id = 100,
                  Name = "Luan",
                  Salary = 1500
            };
            Customer customer2 = new Customer()
            {
                  Id = 130,
                  Name = "Trang",
                  Salary = 5100
            };
            Customer customer3 = new Customer()
            {
                  Id = 103,
                  Name = "Hue",
                  Salary = 7000
            };

            //Customer[] customers=new Customer[2];
            //customers[0]=customer1;
            //customers[1]=customer2;
            //customers[2]=customer3; // # arrary can not grow in size automatically

            //List<Customer> customers = new List<Customer>(2);
            //customers.Add(customer1);
            //customers.Add(customer2);
            //customers.Add(customer3); // list can grow in size automatically

            
            //Customer c=customers[2];
            //Console.Write("Id = {0}, Name = {1}, Salary = {2}", c.Id, c.Name, c.Salary);

            
            //foreach(Customer c in customers)
            //{
            //      Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", c.Id, c.Name, c.Salary);
            //      Console.WriteLine("-----------------------------------------------");
            //}

            
            //for(int i = 0;i < customers.Count;i++)
            //{
            //      Customer c = customers[i];
            //      Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", c.Id, c.Name, c.Salary);
            //}

            //###############################################################################
            //#            Strongly Type

            //customers.Add(102); 

            //SavingsCustomer sc=new SavingsCustomer();
            //customers.Add(sc);

            //customers.Insert(0,customer3);

            //customers.IndexOf(sc);

            //################################################################################
            //#                        Some Function
            //#
            //if(customers.Contains(customer3))
            //{
            //      Console.WriteLine("Customer3 object exists in the list");
            //}
            //else
            //{
            //      Console.WriteLine("Customer3 object does not exist in the list");
            //}

            //if(customers.Exists(cust=>cust.Name.StartsWith("P")))
            //{
            //      Console.WriteLine("Customer3 object exists in the list");
            //}
            //else
            //{
            //      Console.WriteLine("Customer3 object does not exist in the list");
            //}

            //Customer c = customers.Find(cust=>cust.Salary>5000);
            //if(c!=null)
            //Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", c.Id, c.Name, c.Salary);

            //Customer c = customers.FindLast(cust => cust.Salary > 12000);
            //if(c != null)
            //Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", c.Id, c.Name, c.Salary);


            //List<Customer> cs = customers.FindAll(cust => cust.Salary > 12000);
            //foreach(Customer c in cs)
            //{
            //      Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", c.Id, c.Name, c.Salary);
            //}

            //int index= customers.FindIndex(c=>c.Salary>12000);
            //Console.WriteLine("Index = {0}", index); // equal = -1 if it does't find any item

            //int index = customers.FindLastIndex(c => c.Salary >= 7000);
            //Console.WriteLine("Index = {0}", index); // equal = -1 if it does't find any item

            //################################################################################
            //#                        Convert 
            //#

            //Customer[] customers = new Customer[3];
            //customers[0] = customer1;
            //customers[1] = customer2;
            //customers[2] = customer3;
            //List<Customer> listCustomers= customers.ToList();


            //List<Customer> customers = new List<Customer>();
            //customers.Add(customer1);
            //customers.Add(customer2);
            //customers.Add(customer3);
            //Customer[] listCustomers= customers.ToArray();
            
            //foreach(Customer c in listCustomers)
            //{
            //       Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", c.Id, c.Name, c.Salary);
            //}


            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            Dictionary<int,Customer> dictionary= customers.ToDictionary(x => x.Id);

            foreach(KeyValuePair<int, Customer> kvp in dictionary)
            {
                  Console.WriteLine("Key = {0}",kvp.Key);
                  Customer c=kvp.Value;
                  Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", c.Id, c.Name, c.Salary);
                  Console.WriteLine("----------------------------------------");
            }
      }
}

class Customer
{
      public int Id { get; set; }
      public string Name { get; set; }
      public int Salary { get; set; }
}
class SavingsCustomer: Customer
{

}
