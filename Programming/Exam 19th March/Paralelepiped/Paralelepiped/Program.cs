using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paralelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 4 * n + 4;
            int width = 3 * n + 1;
            int a = (height - 2)/2 - 1;
            int b = (height - 2) / 2 - 1;
            Console.WriteLine("+" + new string('~', n - 2) + "+" + new string('.' , width - (n-2) - 2));
            //Console.WriteLine("|" + "\\" + new string('~', n - 2) + "\\" + new string('.', width - (n - 2) - 3));
            for(int i = 0 ; i < (height - 2) / 2 ; i ++)
            {
                Console.WriteLine("|" + new string('.', i) + "\\" + new string('~', n - 2) + "\\" + new string('.', a));
                a--;
            }
            for(int j = 0 ; j < (height - 2) / 2 ; j++)
            {
                Console.WriteLine(new string('.', j) + "\\" + new string('.', b) + "|" + new string('~', n - 2) + "|");
                b--;
            }
            Console.WriteLine(new string('.', width - (n - 2) - 2) + "+" + new string('~', n - 2) + "+");
        }
    }
}
