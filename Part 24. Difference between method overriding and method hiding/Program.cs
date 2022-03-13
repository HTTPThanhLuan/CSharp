using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_24.Difference_between_method_overriding_and_method_hiding
{
      // ####################################################################################################################
      // #                                DIFFERENCE
      // #
      // #   In method overriding a base class reference variable pointing to a child class object, will invoke the 
      // #      overridden method in the Child class
      // #
      // #   In method hiding a base class reference variable pointing to a child class object, will invoke the hidden
      // #      method in the Base class
      // #   
      // #
      // ####################################################################################################################

      //###############################################################
      //#                     Method overriding
      class OverBaseClass
      {
            public virtual void Print()
            {
                  Console.WriteLine("Base Class Print Method -- Overriding");
            }
      }
      class OverDerivedClass: OverBaseClass
      {
            public override void Print()
            {
                  Console.WriteLine("Derived Class Print Method -- Overriding");
            }
      }
      //################################################################
      //#                     Method hiding
      class HidingBaseClass
      {
            public void Print()
            {
                  Console.WriteLine("Base Class Print Method -- Hiding");
            }
      }
      class HidingDerivedClass: HidingBaseClass
      {
            public new void Print()
            {
                  Console.WriteLine("Derived Class Print Method -- Hiding");
            }
      }
      //################################################################
      class Program
      {
            static void Main(string[] args)
            {
                  OverBaseClass overBase=new OverDerivedClass();
                  overBase.Print();

                  HidingBaseClass hidingBase=new HidingDerivedClass();
                  hidingBase.Print();
            }
      }
}
