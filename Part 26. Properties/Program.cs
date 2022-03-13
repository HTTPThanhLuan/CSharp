using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_26.Properties
{
      // ####################################################################################################################
      // #                                PROPERTIES
      // #
      // #    In C# to encapsulate and protect fields we use properties
      // # 
      // # 1. We use get and set accessors to implement properties
      // # 
      // # 2. A property with both get and set accessor is a Read/Write property
      // # 
      // # 3. A property with only get accessor is a RAED ONLY property   
      // # 
      // # 4. A property with only set accessor is a WRITE ONLY property
      // # 
      // #   NOTE: the advantage of properties over traditional Get() and Set() methods is that, 
      // #         you can access them as if they were public fields
      // #
      // #                        AUTO IMPLEMENTED PROPERTIES
      // #
      // #  1. If there is no additional logic in the property accessors, then we can make use of auto-implemented properties
      // #     introduced in c# 3.0
      // #
      // #  2. Auto-implemented properties reduce the amount of code that we have to write
      // #     
      // #  3. When you use auto-implemented properties, the compiler creates a private, anonymous field that can only be 
      // #     accessed through the property's get and set accessors
      // #
      // ####################################################################################################################

      class Program
      {
            static void Main(string[] args)
            {
            }
      }
}
