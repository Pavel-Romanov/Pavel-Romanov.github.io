﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Choose_a_drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            switch(profession)
            {
                case "Athlete": Console.WriteLine("Water"); break;
                case "Businesswoman": Console.WriteLine("Coffee"); break;
                case "Businessman": Console.WriteLine("Coffee"); break;
                case "SoftUni Student": Console.WriteLine("Beer"); break;
                default: Console.WriteLine("Tea"); break;
            }

        }
    }
}
