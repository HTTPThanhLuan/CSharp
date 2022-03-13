using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
      // ####################################################################################################################
      // #                                Method Overloading
      // #
      // #  1. Function overloading and method overloading terms are used interchangeably
      // #
      // #  2. Method overloading allows a class to have multiple methods with the same name   
      // #     
      // #  3. Based on the number, type, kind of parameters 
      // #     BUT NOT include the return type and the params modifier
      // #   
      // #      NOTE: 
      // #            Type of parameters such as int, float, string, ...
      // #            Kind of parameters such as value, ref, out  
      // #   
      // #
      // ####################################################################################################################

      class Program
      {
            static void Main(string[] args)
            {
                 Program pro=new Program();
                // pro.Add();
            }

            //#########################################################
            //#               Number of parameters

            //public void Add(int FN, int SN)
            //{
            //      Console.WriteLine("Sum= {0}", FN + SN);
            //}
            //public void Add(int FN, int SN, int TN)
            //{
            //      Console.WriteLine("Sum= {0}", FN + SN + TN);
            //}

            //#########################################################
            //#               Type of parameters
            //public void Add(int FN, int SN)
            //{
            //      Console.WriteLine("Sum= {0}", FN + SN);
            //}
            //public void Add(int FN, string SN)
            //{
            //      Console.WriteLine("Int = {0} String = {1}", FN, SN );
            //}

            //#########################################################
            //#               Kind of parameters
            public void Add(int FN, int SN)
            {
                  Console.WriteLine("Sum= {0}", FN + SN);
            }
            public void Add(int FN, out int SN)
            {
                  Console.WriteLine("Int = {0}", FN);
                  SN=1;
            }
      }
}
