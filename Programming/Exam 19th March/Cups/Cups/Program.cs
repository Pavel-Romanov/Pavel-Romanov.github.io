using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            var planned_cups = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var hours_worked = workers * days * 8;
            var cups_made = hours_worked / 5;
            
            if(cups_made > planned_cups)
            {
                var win = (cups_made - planned_cups) * 4.20;
                Console.Write("{0:F2}",win);
                Console.Write(" extra money");
                Console.WriteLine();
            }
            if(cups_made < planned_cups)
            {
                var losses = (planned_cups - cups_made) * 4.20;
                Console.Write("Losses: ");
                Console.Write("{0:F2}",losses);
                Console.WriteLine();
            }
        }
    }
}
