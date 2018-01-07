using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int boundary_sum = int.Parse(Console.ReadLine());
            int combinations = 0;
            int sum = 0;

            for(int i = a ; i >= 1 ; i --)
            {
                for(int j = 1 ; j <= b ; j ++)
                {
                    combinations++;
                    sum = sum + 3 * (i * j);

                    if (sum >= boundary_sum)
                    {
                        Console.WriteLine(combinations + " combinations");
                        Console.WriteLine("Sum: " + sum + " >= "  + boundary_sum);
                        return;
                    }


                }   
            }
            if(sum < boundary_sum)
            {
                Console.WriteLine(combinations + " combinations");
                Console.WriteLine("Sum: " + sum);
            }
            
        }
    }
}
