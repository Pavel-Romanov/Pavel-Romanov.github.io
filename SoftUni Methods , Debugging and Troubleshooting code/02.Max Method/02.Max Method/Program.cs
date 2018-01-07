using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static int GetMax(int a , int b)
        {
            if (a > b)
                return a;
            else return b;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int one = GetMax(a, b);
            int max = GetMax(one, c);
            Console.WriteLine(max);
        }
    }
}
