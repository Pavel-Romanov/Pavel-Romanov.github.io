using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;
            int height = 2 * n + 1;
            int a = n;
            Console.WriteLine(new string('*' , width));
            Console.WriteLine(".*" + new string(' ', width - 4) + "*.");
            for(int i = 2 ; i <= n - 1 ; i++)
            {
                Console.WriteLine(new string('.' , i) + "*" + new string('@' , height - i - 4 )+ "*" + new string('.' , i));
                height--;
            }
            Console.WriteLine(new string('.', n) + "*" + new string('.', n));
            for(int j = 0 ; j < n - 2 ; j ++)
            {
                
                Console.WriteLine(new string('.' , a - 1 ) + "*" + new string(' ' , j) + "@" +  new string(' ' , j) + "*" + new string('.' , a - 1 ));
                a--;
            }
            Console.WriteLine(".*" + new string('@', width - 4) + "*.");
            Console.WriteLine(new string('*' , width));

        }
    }
}
