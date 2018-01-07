using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            

            if(num == 1 || num == 2 )
            {
                Console.WriteLine("Prime");
                return;
            }

            for (int i = 2; i <= num; i++)
            {
                bool check_prime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        check_prime = false;
                        break;
                    }
                }
                Console.WriteLine(i + " -> " + check_prime);
            }
            
        }
    }
}
