using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool a = true;

            if( n < 2 )
                {
                    Console.WriteLine("Not Prime");
                }
            
           // while(a == true)
           // {
                for(int i = 2 ; i <= Math.Floor(Math.Sqrt(n)) ; i++)
                {
                    if (n % i == 0)
                    {
                        a = false;
                        break;
                    }
                }
           // }
            if (a == true)
            {
                Console.WriteLine("Prime");
            }
            if(a == false)
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
