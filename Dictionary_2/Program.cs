using System;
using System.Collections.Generic;
using System.Linq;

// ####################################################################################################################
// #                                Dictionary continue
// #
// #   1. TryGetValue()
// #     
// #   2. Count()
// #   
// #   3. Remove()   
// #   
// #   4. Clean()
// #   
// #   5. Using LINQ extension methods with Dictionary
// #      
// #   6. Different ways to convert an array into a dictionary
// #
// ####################################################################################################################

class Program
{

      static void Main(string[] args)
      {

            Customer customer1 = new Customer()
            {
                  Id = 100,
                  Name = "Luan",
                  Salary = 1200
            };
            Customer customer2 = new Customer()
            {
                  Id = 130,
                  Name = "Trang",
                  Salary = 600
            };
            Customer customer3 = new Customer()
            {
                  Id = 103,
                  Name = "Hue",
                  Salary = 300
            };

            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();

            dictionaryCustomers.Add(customer1.Id, customer1);
            dictionaryCustomers.Add(customer2.Id, customer2);
            dictionaryCustomers.Add(customer3.Id, customer3);

            //###############################################################################################
            //#                     TryGetValue() 
            //# If you not sure the key is not exist. 
            //Customer cust;
            //if(dictionaryCustomers.TryGetValue(600, out cust))
            //{
            //      Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
            //}
            //else
            //{
            //      Console.WriteLine("They key is not found");
            //}

            //###############################################################################################
            //#                     Count() 
            //# If you not sure the key is not exist. 

            //Console.WriteLine("Total Item = {0}", dictionaryCustomers.Count);

            //###############################################################################################
            //#              Using LINQ extension methods with Dictionary  Count()  
            //# If you not sure the key is not exist. 

            Console.WriteLine("Total Item = {0}", dictionaryCustomers.Count(kvp => kvp.Value.Salary > 300));

            //###############################################################################################
            //#              Remove 
            //# If you not sure the key is not exist. 
            dictionaryCustomers.Remove(999);

            //###############################################################################################
            //#              Clear
            //# If you not sure the key is not exist.
 
            dictionaryCustomers.Clear();

            //###############################################################################################
            //#              Different ways to convert an arrary into Dictionary
            //# If you not sure the key is not exist. 
            //Customer[] customers = new Customer[3];
            //customers[0] = customer1;
            //customers[1] = customer2;
            //customers[2] = customer3;

            //Dictionary<int, Customer> dict = customers.ToDictionary(cust => cust.Id, cust => cust);
            //foreach(KeyValuePair<int, Customer> kvp in dict)
            //{
            //      Console.WriteLine("Key = {0}", kvp.Key);
            //      Customer cust = kvp.Value;
            //      Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
            //      Console.WriteLine("--------------------------------------------------------");
            //}

            
            //###############################################################################################
            //#              Different ways to convert an List into Dictionary
            
            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            
            Dictionary<int, Customer> dict = customers.ToDictionary(cust => cust.Id, cust => cust);
            foreach(KeyValuePair<int, Customer> kvp in dict)
            {
                  Console.WriteLine("Key = {0}", kvp.Key);
                  Customer cust = kvp.Value;
                  Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
                  Console.WriteLine("--------------------------------------------------------");
            }

      }
}
class Customer
{
      public int Id { get; set; }
      public string Name { get; set; }
      public int Salary { get; set; }
}
