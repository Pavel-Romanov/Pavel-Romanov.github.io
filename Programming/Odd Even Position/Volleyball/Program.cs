using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            double odd_sum = 0;
            double odd_min = -10000000.0;
            double odd_max = 10000000.0;
            double even_sum = 0;
            double even_min = 0;
            double even_max = 0;

            if (n == 0)
                {
                    Console.WriteLine("OddSum=" + odd_sum + ",");
                    Console.WriteLine("OddMin=No,");
                    Console.WriteLine("OddMax=No,");
                    Console.WriteLine("EvenSum=" + even_sum + ",");
                    Console.WriteLine("EvenMin=No,");
                    Console.WriteLine("EvenMax=No");
                }

            for (int i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                
                 if (n == 1)
                {
                    odd_sum += num;
                    Console.WriteLine("OddSum=" + odd_sum + ",");
                    Console.WriteLine("OddMin=" + num + ",");
                    Console.WriteLine("OddMax=" + num + ",");
                    Console.WriteLine("EvenSum=" + even_sum + ",");
                    Console.WriteLine("EvenMin=No,");
                    Console.WriteLine("EvenMax=No");
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        even_sum += num;
                        if (i == 2)
                        {
                            even_max = num;
                            even_min = num;
                        }

                        if (num > even_max)
                        {
                            even_max = num;
                        }

                        else if (num < even_min)
                        {
                            even_min = num;
                        }
                    }
                    if (i % 2 == 1)
                    {
                        odd_sum += num;
                        if (i == 1)
                        {
                            odd_max = num;
                            odd_min = num;
                        }

                        if (num > odd_max)
                        {
                            odd_max = num;
                        }

                        else if (num < odd_min)
                        {
                            odd_min = num;
                        }
                    }
                    Console.WriteLine("OddSum=" + odd_sum + ",");
                    Console.WriteLine("OddMin=" + odd_min + ",");
                    Console.WriteLine("OddMax=" + odd_max + ",");
                    Console.WriteLine("EvenSum=" + even_sum + ",");
                    Console.WriteLine("EvenMin=" + even_min + ",");
                    Console.WriteLine("EvenMax=" + even_max);
                }
            }
            
        }
    }
}
/* 
6
1
2
3
4
5
6
*/