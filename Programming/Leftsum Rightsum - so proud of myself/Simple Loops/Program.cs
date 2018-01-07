using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftsum = 0;
            int rightsum = 0;
            for(int i = 1 ; i <= 2 ; i++)
            {
               for(int j = 0 ; j < n ; j++)
               {
                   int num = int.Parse(Console.ReadLine());
                   if (i == 1)
                   {
                       leftsum += num;
                   }
                   else rightsum += num;
               }
            }
            if (leftsum == rightsum)
            {
                Console.WriteLine("Yes, sum = " + leftsum);
            }
            else
                Console.WriteLine("No, diff = " + Math.Abs(leftsum - rightsum));
        }
    }
}
