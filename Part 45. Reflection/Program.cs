using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
      // ####################################################################################################################
      // #                                         REFLECTION
      // #
      // #   
      // #     
      // #   
      // #   
      // #      
      // #   
      // #
      // #   
      // #   
      // #      
      // #   
      // #
      // ####################################################################################################################

      public class Program
      {
            static void Main(string[] args)
            {
                  Type T = Type.GetType("Reflection.Customer");
                  
                  //Type T=typeof(Customer);
                 
                  //Customer cs=new Customer();
                  //Type T=cs.GetType();

                  Console.WriteLine("Full name = {0}", T.FullName);
                  Console.WriteLine("Just the Name = {0}", T.Name);
                  Console.WriteLine("Just the Namespace = {0}", T.Namespace);
                  Console.WriteLine();
                  Console.WriteLine("Properties in Customer");
                  PropertyInfo[] properties = T.GetProperties();
                  foreach(PropertyInfo property in properties)
                  {
                        Console.WriteLine(property.PropertyType.Name + " " + property.Name);
                  }
                  Console.WriteLine();
                  Console.WriteLine("Method in Customer");
                  MethodInfo[] methods = T.GetMethods();
                  foreach(MethodInfo method in methods)
                  {
                        Console.WriteLine(method.ReturnType.Name + " " + method.Name);
                  }
                  Console.WriteLine();
                  Console.WriteLine("Constructor in Customer");
                  ConstructorInfo[] constructors=T.GetConstructors();
                  foreach(ConstructorInfo constructor in constructors)
                  {
                        Console.WriteLine(constructor.ToString());
                  }

            }
      }

      public class Customer
      {
            private int _id;
            private string _name;
            public int Id
            {
                  get { return _id; }
                  set { _id = value; }
            }
            public string Name
            {
                  get { return _name; }
                  set { _name = value; }
            }
            public Customer(int Id, string Name)
            {
                  this._id = Id;
                  this._name = Name;
            }
            public Customer()
            {
                  this._id = 1;
                  this._name = string.Empty;
            }
            public void PrintID()
            {
                  Console.WriteLine("ID = {0}", this.Id);
            }
            public void PrintName()
            {
                  Console.WriteLine("Name = {1}", this.Name);
            }

      }
}
