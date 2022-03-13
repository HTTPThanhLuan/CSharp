using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_07.Data_Type
{
      class Program
      {
            static void Main(string[] args)
            {
                  // TimeSpanStruct timeSpan = new TimeSpanStruct();
                  //    timeSpan.TimeSpan_Test();

                  object s = "Luan";
               Type t=   s.GetType();


                var firsDayOfWeek =  DateTimeExtensions.FirstDayOfWeek(DateTime.Now);
                var lastDayOfWeek =    DateTimeExtensions.LastDayOfMonth(DateTime.Now);

                  int i = 0;
            }
      }
}
