using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
      static void Main(string[] args)
      {
            Customer customer1 = new Customer()
            {
                  Id = 100,
                  Name = "Muoi",
                  Salary = 1500,
                  Type="RetailCustomer"
            };
            Customer customer2 = new Customer()
            {
                  Id = 101,
                  Name = "Ben",
                  Salary = 5100,
                  Type = "RetailCustomer"
            };
            Customer customer3 = new Customer()
            {
                  Id = 102,
                  Name = "Luan",
                  Salary = 7000,
                  Type = "RetailCustomer"
            };
            Customer customer4 = new Customer()
            {
                  Id = 103,
                  Name = "Trang",
                  Salary = 6500,
                  Type = "CorporateCustomer"
            };
            Customer customer5 = new Customer()
            {
                  Id = 104,
                  Name = "Hue",
                  Salary = 3500,
                  Type = "CorporateCustomer"
            };

            List<Customer> listCustomers=new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            List<Customer> listCorporateCustomer=new List<Customer>();
            listCorporateCustomer.Add(customer4);
            listCorporateCustomer.Add(customer5);

            listCustomers.AddRange(listCorporateCustomer);

            //foreach(Customer c in listCustomers)
            //{
            //      Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3} ", c.Id, c.Name, c.Salary, c.Type  );
            //}

            List<Customer> customers=   listCustomers.GetRange(3,2);


            foreach(Customer c in customers)
            {
                  Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3} ", c.Id, c.Name, c.Salary, c.Type);
            }

      }
}

class Customer
{
      public int Id { get; set; }
      public string Name { get; set; }
      public int Salary { get; set; }
      public string  Type { get; set; }
}

