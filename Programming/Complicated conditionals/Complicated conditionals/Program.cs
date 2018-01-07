using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complicated_conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            double weekends = 48;
            double games_p = p * (2.0 / 3);
            double games_h = h;
            double games_sofia = (weekends - h) * (3.0 / 4);
            double result = games_h + games_p + games_sofia;

            if(year == "normal")
            {
                Console.WriteLine(Math.Truncate(result));
            }
            if(year == "leap")
            {
                Console.WriteLine(Math.Truncate((result * 0.15) + result));
            }

        }
    }
}