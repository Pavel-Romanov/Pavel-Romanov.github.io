using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var front_wall = (x * x) - (1.2 * 2);
            var back_wall = x * x;
            var side_wall = (x * y) - (1.5 * 1.5); //2 walls
            var side_roof = x * y; // 2 
            var front_roof = (x * h) / 2; //2
            var all_roof = ((2 * side_roof) + (2 * front_roof)) / 4.3;
            var all_walls = (front_wall + back_wall + 2 * side_wall) / 3.4;
            Console.WriteLine("{0:F2}" , all_walls);
            Console.WriteLine("{0:F2}" , all_roof );



        }
    }
}
