using System;
using System.Collections.Generic;


class Program
{
      static void Main(string[] args)
      {
            
            Customer[] customers = new Customer[3];
            customers[0] = new Customer
            {
                  Name = "Mark",
                  // Gender = 1
                  Gender = Gender.Male
            };
            customers[1] = new Customer
            {
                  Name = "Mary",
                  // Gender = 2
                  Gender = Gender.Female
            };

            customers[2] = new Customer
            {
                  Name = "Sam",
                  // Gender = 0
                  Gender = Gender.Unknow
            };
            foreach(var item in customers)
            {
                  Console.WriteLine("Name = {0} && Gender = {1}", item.Name, GetGender(item.Gender));
            }

      }
      //static string Gender(int gender)
      //{
      //      switch(gender)
      //      {
      //            case 0: return "Unknow";
      //            case 1: return "Male";
      //            case 2: return "Female";
      //            default: return "Invalid data detected";
      //      }
      //}
      static string GetGender(Gender gender)
      {
            switch(gender)
            {
                  //case 0: return "Unknow";
                  //case 1: return "Male";
                  //case 2: return "Female";
                  //default: return "Invalid data detected";
                  case Gender.Unknow: return "Unknow";
                  case Gender.Male: return "Male";
                  case Gender.Female: return "Female";
                  default: return "Invalid data detected";
            }
      }
}

enum Gender
{
      Unknow,
      Male,
      Female
}

// 0 Unknow
// 1 Male
// 2 Female
class Customer
{
      public string Name { get; set; }
      // public int Gender { get; set; }
      public Gender Gender { get; set; }
}
