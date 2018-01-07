using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_with_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n ; i++)
            {
                Console.Write(new string(' ', n - i ));
                for(int j = i ; j <= i ; j++)
                {
                    Console.Write(new string('*', i));
                    Console.Write(" | ");
                    Console.Write(new string('*', i));
                }
                Console.WriteLine();
            }
            
        }
    }
}
