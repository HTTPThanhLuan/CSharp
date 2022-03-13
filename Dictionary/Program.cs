using System;
using System.Collections.Generic;

// ####################################################################################################################
// #                                Dictionary
// #
// #   1. A dictionary is a collection of (key, value) pairs.
// #     
// #   2. Dictionary class is present in System.Collectioins.Generic namespace.
// #   
// #   3. When creating a dictinonary, we need to spectify the type for key and value   
// #   
// #   4. Dictionary provides fast lookups for values using keys.
// #   
// #   5. Keys in the dictionary must the unique.
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


            //if(!dictionaryCustomers.ContainsKey(customer1.Id))
            //{ 
            //      dictionaryCustomers.Add(customer1.Id, customer3); 
            //}

            if(dictionaryCustomers.ContainsKey(200))
            {
                  Customer customer200 = dictionaryCustomers[200];
            }



            Customer customer100 = dictionaryCustomers[100];
            Console.WriteLine("ID = {0} Name = {1} Salary = {2}",
                  customer100.Id, customer100.Name, customer100.Salary);

            //foreach(KeyValuePair<int, Customer> customerKeyValuePair in dictionaryCustomers)
            //{
            //      Console.WriteLine("ID = {0}", customerKeyValuePair.Key);
            //      Customer customer = customerKeyValuePair.Value;
            //      Console.WriteLine("ID = {0} Name = {1} Salary = {2}", customer.Id, customer.Name, customer.Salary);
            //      Console.WriteLine("-------------------------------------------------------------------");
            //}


            //foreach(var customerKeyValuePair in dictionaryCustomers)
            //{
            //      Console.WriteLine("ID = {0}", customerKeyValuePair.Key);
            //      Customer customer = customerKeyValuePair.Value;
            //      Console.WriteLine("ID = {0} Name = {1} Salary = {2}", customer.Id, customer.Name, customer.Salary);
            //      Console.WriteLine("-------------------------------------------------------------------");
            //}


            //foreach(int key in dictionaryCustomers.Keys)
            //{
            //      Console.WriteLine("ID = {0}", key);
            //      Console.WriteLine("----------------------------------");
            //}


            //foreach(Customer customer in dictionaryCustomers.Values)
            //{
            //      Console.WriteLine("ID = {0} Name = {1} Salary = {2}", customer.Id, customer.Name, customer.Salary);
            //      Console.WriteLine("--------------------------------------");
            //}


      }
}
class Customer
{
      public int Id { get; set; }
      public string Name { get; set; }
      public int Salary { get; set; }
}
