﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_07.Data_Type
{
      public static partial class DateTimeExtensions
      {
          //  https://markb.co.uk/csharp-datetime-get-first-last-day-of-week-or-month.html
            public static DateTime FirstDayOfWeek(this DateTime dt)
            {
                  var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
                  var diff = dt.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
                  if (diff < 0)
                        diff += 7;
                  return dt.AddDays(-diff).Date;
            }

            public static DateTime LastDayOfWeek(this DateTime dt)
            {
                  return dt.FirstDayOfWeek().AddDays(6);
            }

            public static DateTime FirstDayOfMonth(this DateTime dt)
            {
                  return new DateTime(dt.Year, dt.Month, 1);
            }

            public static DateTime LastDayOfMonth(this DateTime dt)
            {
                  return dt.FirstDayOfMonth().AddMonths(1).AddDays(-1);
            }

            public static DateTime FirstDayOfNextMonth(this DateTime dt)
            {
                  return dt.FirstDayOfMonth().AddMonths(1);
            }
      }
}
