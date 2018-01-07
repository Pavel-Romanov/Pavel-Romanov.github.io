using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_in_Patience
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int x = 0;
            int x1 = 1;
            int x2 = 0 ;
            int y = 0;
            int y1 = 1;
            int y2 = 0;
                for(int i = 3 ; i <= n ; i++)
                    {
                        x2 = x + x1;
                        x = x1;
                        x1 = x2;
                    }
                for (int j = 3; j <= k; j++)
                {
                    y2 = y + y1;
                    y = y1;
                    y1 = y2;
                }
            Console.WriteLine(x2/y2);
        }

    }
}

