using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci
{
    class Program
    {
        static int fibonacci(int n )
        {
            int a = 1;
            int b = 1;
            int c = 0;
            for (int i = 1; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n == 0 || n == 1 )
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(fibonacci(n));
            }
            
        }
    }
}
