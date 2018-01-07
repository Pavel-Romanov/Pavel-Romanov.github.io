using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
             if (a > b)
             {
                 for(int i = b ; i <= a ; i++)
                 {
                     Console.WriteLine(i);
                 }
             }
            if(b > a)
            {
                for(int j = a ; j <= b ; j++)
                {
                    Console.WriteLine(j);
                }
            }
            if(a == b)
            {
                return;
            }
        }
    }
}
