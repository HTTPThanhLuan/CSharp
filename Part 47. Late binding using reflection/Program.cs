using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pragim
{
       // ####################################################################################################################
      // #                                EARLY v/s Late Binding
      // #
      // #   1. Early binding can flag errors at compile time, with late binding there is a risk of run time exceptions
      // #     
      // #   2. Early binding is much better for performance and should always be preferred over late binding.
      // #      Use late binding only when working with an objects that are not available at compile time.   
      // #
      // ####################################################################################################################

      class Program
      {
            static void Main(string[] args)
            {
                 //##################################################################################
                  //#                                  Late Binding
                 //Assembly executingAssembly = Assembly.Load("System.String");
                  Assembly executingAssembly= Assembly.GetExecutingAssembly();

                  Type customerType = executingAssembly.GetType("Pragim.Customer");

                  object customerInstance= Activator.CreateInstance(customerType);

                  MethodInfo getFullNameMethod= customerType.GetMethod("GetFullName");

                  string[] parameters=new string[2];
                  parameters[0]="Pragim";
                  parameters[1]="Technologies";

                  string fullName=(string)getFullNameMethod.Invoke(customerInstance,parameters);
                  Console.WriteLine(fullName);

                  //##################################################################################
                  //#                                     Early Binding
                  //Customer Cu=new Customer();
                  //string fullName= Cu.GetFullName("Pragim", "Tech");
                  //Console.WriteLine(fullName);
            }
      }

      public class Customer
      {
            public string GetFullName(string FN, string LN)
            {
                  return FN + " - " + LN;
            }
      }
}
