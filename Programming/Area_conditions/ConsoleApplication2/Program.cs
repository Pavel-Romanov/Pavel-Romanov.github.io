using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); 
            

            switch(input)
            {
                case "square":
                    { 
                       var square_wall = double.Parse(Console.ReadLine());
                       double s_square = square_wall * square_wall ; 
                       Console.WriteLine(Math.Round(s_square , 3) );
                        break;
                    }
                case "circle":
                    {
                        var circle_r = double.Parse(Console.ReadLine());
                        double s_circle = circle_r * circle_r * Math.PI;
                        Console.WriteLine(Math.Round(s_circle , 3));
                        break;
                    }
                case "rectangle":
                    {
                        var rectangle_wall1 = double.Parse(Console.ReadLine());
                        var rectangle_wall2 = double.Parse(Console.ReadLine());
                        double s_rectangle = rectangle_wall1 * rectangle_wall2;
                        Console.WriteLine(Math.Round(s_rectangle , 3)) ;
                        break;
                    }
                case "triangle":
                    {
                        var triangle_wall = double.Parse(Console.ReadLine());
                        var triangle_height = double.Parse(Console.ReadLine());
                        double s_triangle = triangle_height * triangle_wall / 2;
                        Console.WriteLine( Math.Round(s_triangle , 3));
                        break;
                    } 

            }
        }
    }
}
