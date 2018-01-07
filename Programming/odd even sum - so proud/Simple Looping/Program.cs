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
            int oddsum = 0;
            int evensum = 0;
                for (int j = 0; j < n; j++)
                {
                    int num = int.Parse(Console.ReadLine());
                    if (j % 2 == 1)
                    {
                        oddsum += num;
                    }
                    else evensum += num;
                }

            if (oddsum == evensum)
            {
                Console.WriteLine("Yes, sum = " + oddsum);
            }
            else
                Console.WriteLine("No, diff = " + Math.Abs(oddsum - evensum));
        }
    }
}
