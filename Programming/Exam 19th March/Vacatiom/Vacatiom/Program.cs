using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacatiom
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            var money_spent = 1.00;
            string location = "cheese";

            if (budget <= 1000)
            {
                switch (season)
                {
                    case "Summer": money_spent = budget * 0.65;
                        location = "Alaska";
                        break;
                    case "Winter": money_spent = budget * 0.45;
                        location = "Morocco";
                        break;
                }
                Console.WriteLine(location + " " + "- Camp -" + " " + "{0:F2}", money_spent);
            }
                if(budget > 1000 && budget <= 3000)
            {
                switch(season)
                {
                    case "Summer": money_spent = budget * 0.80;
                         location = "Alaska";
                        break;
                    case "Winter": money_spent = budget * 0.60;
                         location = "Morocco";
                         break;
                }
                Console.WriteLine(location + " " + "- Hut -" + " " + "{0:F2}", money_spent);
            }
                if (budget > 3000)
                {
                    switch (season)
                    {
                        case "Summer": money_spent = budget * 0.90;
                            location = "Alaska";
                            break;
                        case "Winter": money_spent = budget * 0.90;
                            location = "Morocco";
                            break;
                    }
                    Console.WriteLine(location + " " + "- Hotel -" + " " +"{0:F2}", money_spent);
                }
        }
    }
}
