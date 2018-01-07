using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_drink_v2
{
   
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            double n = double.Parse(Console.ReadLine());
           // double total_athlete = n * 0.70;
            switch(profession)
            {
                case "Athlete": Console.Write("The " + profession + " has to pay "); Console.Write("{0:F2}", n * 0.70); Console.Write("."); Console.WriteLine(); break;
                case "Businesswoman": Console.Write("The " + profession + " has to pay "); Console.Write("{0:F2}", n * 1.00); Console.Write("."); Console.WriteLine(); break;
                case "Businessman": Console.Write("The " + profession + " has to pay "); Console.Write("{0:F2}", n * 1.00); Console.Write("."); Console.WriteLine(); break;
                case "SoftUni Student": Console.Write("The " + profession + " has to pay "); Console.Write("{0:F2}", n * 1.70); Console.Write("."); Console.WriteLine(); break;
                default: Console.Write("The " + profession + " has to pay "); Console.Write("{0:F2}", n * 1.20); Console.Write("."); Console.WriteLine(); break;
            }
            

        }
    }
}
