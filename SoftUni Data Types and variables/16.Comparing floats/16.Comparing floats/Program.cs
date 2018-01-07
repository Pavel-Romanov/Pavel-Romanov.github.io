using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            if((a > b && (a-b)<eps) || (b > a && (b - a ) < eps))
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");

        }
    }
}
/*
5.00000005
5.00000001
*/