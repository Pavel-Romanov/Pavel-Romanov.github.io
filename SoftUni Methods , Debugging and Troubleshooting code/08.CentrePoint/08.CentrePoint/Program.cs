using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CentrePoint
{
    class Program
    {
        static void CentrePoint()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            if (Math.Sqrt(x1 * x1 + y1 * y1) < Math.Sqrt(x2 * x2 + y2 * y2))
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
            else if (Math.Sqrt(x1 * x1 + y1 * y1) == Math.Sqrt(x2 * x2 + y2 * y2))
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
            else if (Math.Sqrt(x1 * x1 + y1 * y1)  > Math.Sqrt(x2 * x2 + y2 * y2))
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
        }
        static void Main(string[] args)
        {
            CentrePoint();
        }
    }
}
