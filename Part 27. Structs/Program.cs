using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_28.Structs
{
      // ####################################################################################################################################################
      // #                                STRUCTS
      // #           Just Like classes structs can have
      // # 
      // # 1. Private fields
      // # 
      // # 2. Public Properties    
      // # 
      // # 3. Constructors  
      // # 
      // # 4. Method
      // #  
      // # Object initializer syntax, introduced in c#3.0 can be used to initialize either a struct or a class
      // # 
      // # NOTE: There are several differences between classes and structs which we will be looking at in a later session  
      // #
      // #  1. A struct is a value type where as a class is a reference type.
      // #
      // #  2. All the difference that are applicable to value types and reference type are also applicable to classes and structs.
      // #
      // #  3. Structs are stored on stack, where as classes are stored on the heap.
      // #
      // #  4. Value type hold their value in memory where they are declared, but reference types hold a reference to an object in menory
      // # 
      // #  5. Value types are destroyed immediately after the scope is lost, where as for reference types only the reference variable is destroyed
      // #     after the scope is lost. The object is later destroyed by garbage collector. (We will talk about this in the garbage collection session)
      // #  
      // #  6. When you copy a struct into another struct, a new copy of that struct gets created and modifications on one struct will not affect the values
      // #     contained by the other struct.
      // #
      // #  7. When you copy a class into another class, we only get a copy of the reference variable. Both the reference variables point to the same object
      // #     on the heap. So. operations on one variable will affect the values contained by the other reference variable.
      // #
      // #  8. Structs can't have destructors, but classes can have destructors.
      // #
      // #  9. Structs cannot have explicit parameter less constructor where as class can.
      // #  
      // #  10. Struct can't inherit from another class where as a class can. Both structs and classes can inherit from an interface
      // #
      // # Examples of structs in the .NET Framework - int(System.Int32), double(System.Double) etc.
      // #
      // # NOTE: 
      // #
      // # 1. A class or a struct cannot inherit from another struct. Struct are sealed types.
      // #
      // # 2. How do you prevent a class from being inherited? Or What is the significance of sealed keyword?
      // ################################################################################################################################################

      struct Customer
      {
            //Private fields
            private int _id;
            private string _name;

            //Public Properties
            public string Name
            {
                  get { return _name; }
                  set { _name = value; }
            }
            public int ID
            {
                  get { return this._id; }
                  set { this._id = value; }
            }
            // Constructors
            public Customer(int Id, string Name)
            {
                  this._id = Id;
                  this._name = Name;
            }
            // Method
            public void PrintDetails()
            {
                  Console.WriteLine("ID ={0} && Name ={1}",
                        this._id, this._name);
            }


      }
      //class Customer
      //{
      //       //Private fields
      //      private int _id;
      //      private string _name;
            
      //      //Public Properties
      //      public string Name
      //      {
      //            get { return _name; }
      //            set { _name = value; }
      //      }
      //      public int ID
      //      {
      //            get { return this._id; }
      //            set { this._id = value; }
      //      }
      //      // Constructors
      //      public Customer(int Id, string Name)
      //      {
      //            this._id=Id;
      //            this._name=Name;
      //      }
      //      // Method
      //      public void PrintDetails()
      //      {
      //            Console.WriteLine("ID ={0} && Name ={1}",
      //                  this._id,this._name);
      //      }
      //}
      class Program
      {
            static void Main(string[] args)
            {
                  // Struct
                  //Customer c1=new Customer(101,"Mark");
                  //c1.PrintDetails();

                  //Customer c2=new Customer();
                  //c2.ID=102;
                  //c2.Name="John";
                  //c2.PrintDetails();

                  //Customer c3=new Customer{
                  //      ID=103,
                  //      Name="Rod"
                  //};
                  //c3.PrintDetails();

                  //// Class
                  //Customer c=new Customer{
                  //      ID=23,
                  //      Name="Luan"
                  //};
            }
      }
}
