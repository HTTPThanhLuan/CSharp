using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._0_Features_illustrated
{
    class Program
    {
        static void Main(string[] args)
        {

            // Go to https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-6 to continue learning more
            //object points = null;

            List<point> points = new List<point>() { new point { X = 1 }, new point { X = 2 } };
            var bestValue = points?.FirstOrDefault()?.X ?? -1;
            Console.WriteLine(bestValue);

            points = null;
            bestValue = points?.FirstOrDefault()?.X ?? -1;
            Console.WriteLine(bestValue);

            points = new List<point>();
            bestValue = points?.FirstOrDefault()?.X ?? -1;
            Console.WriteLine(bestValue);


        }
    }
    class point
    {
        public int X { get; set; }
    }
}
