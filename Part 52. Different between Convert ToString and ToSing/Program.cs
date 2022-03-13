using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_52
{
      class Program
      {
            // ####################################################################################################################
            // #                                Difference between Convert.ToString() and ToString()
            // #
            // #   Convert.ToString() handles null, while ToString() doen't, and throws a NULL Reference exception
            // #     
            // #   Depending on the type of the application, architecture and what you are trying to achieve, you choose one over the other
            // #   
            // #
            // #############################################################################################################################

            static void Main(string[] args)
            {
                  //Customer customer = new Customer();
                  //string s = customer.ToString();

                  //Customer customer=null;
                  //string s=Convert.ToString(customer);
                  //Console.WriteLine(s);
            }
      }

      public class Customer
      {

      }
}
