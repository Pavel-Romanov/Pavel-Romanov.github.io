using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

                Console.Write(new string('*', n * 2));
                Console.Write(new string(' ', n));
                Console.Write(new string('*', n * 2));
                Console.WriteLine();

            for(int i = 1 ; i <= n - 2 ;i++)
            {  
                if (i == (n-1)/2)
                {
                    Console.Write("*");
                    Console.Write(new string('/', n * 2 - 2));
                    Console.Write("*");
                    Console.Write(new string('|', n));
                    Console.Write("*");
                    Console.Write(new string('/', n * 2 - 2));
                    Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("*");
                    Console.Write(new string('/', n * 2 - 2));
                    Console.Write("*");
                    Console.Write(new string(' ', n));
                    Console.Write("*");
                    Console.Write(new string('/', n * 2 - 2));
                    Console.Write("*");
                    Console.WriteLine();
                }

            }
     
                Console.Write(new string('*', n * 2));
                Console.Write(new string(' ', n));
                Console.Write(new string('*', n * 2));
                Console.WriteLine();
        }
    }
}
