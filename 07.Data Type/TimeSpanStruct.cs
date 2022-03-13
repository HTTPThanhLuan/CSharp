using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_07.Data_Type
{
      //https://msdn.microsoft.com/en-us/library/system.timespan(v=vs.110).aspx
    public   class TimeSpanStruct
      {

            public void TimeSpan_Test()
            {

                  DateTime myDate1 = new DateTime(2017, 7, 31,8, 0, 00);
                  DateTime myDate2 = new DateTime(2017, 7, 31, 9, 0, 00);

                  TimeSpan myDateResult;

                  https://msdn.microsoft.com/en-us/library/system.timespan.op_subtraction(v=vs.110).aspx

                  //myDateResult = myDate2 - myDate1;
                  //myDateResult = myDate2.Subtract(myDate1);

                  //double seconds = myDateResult.TotalSeconds;


                  //var startWork = new TimeSpan(08, 00, 00);
                  //var endWork = new TimeSpan(18, 30, 00);
                  //var lunchBreak = new TimeSpan(1, 0, 0);
                  //var breaks = new TimeSpan(0, 30, 0);

                  //Console.WriteLine("Length of work day: {0}",
                  //                  endWork - startWork);
                  //Console.WriteLine("Actual time worked: {0}",
                  //                  endWork - startWork - (lunchBreak + breaks));


                  var baseDate = new DateTime(1, 1, 1,0,0,0);
                  baseDate = DateTime.MinValue;

                  var tba = baseDate.Ticks;


                  var end = baseDate.AddDays(1.5);
                  var tend = end.Ticks;

                  var t = tend - tba;


                  TimeSpan ts = new TimeSpan(t);

                  Console.Write("{0} years, {1} months and {2} days and {3} minutes",
                                       end.Year - baseDate.Year,
                                       end.Month - baseDate.Month,
                                       end.Day - baseDate.Day,
                                       end.Minute - baseDate.Minute

                                       );

            }

      }
}
