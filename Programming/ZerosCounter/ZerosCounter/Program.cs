using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZerosCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 0;
            int x2 = 1;
            int x3 = 3;
            int counter = 0;
            int n = int.Parse(Console.ReadLine());
            for(int i = 0 ; i < n-1 ; i++)
            {
                x3 = x1 + x2;
                x1 = x2;
                x2 = x3;
            }
            Console.WriteLine(x3);
            while(x3 > 0)        
            {
                int k = x3 % 10;
                if (k == 0) { counter++; }
                x3 = x3 / 10;
            }
            Console.WriteLine(counter);
         }

    }
}
