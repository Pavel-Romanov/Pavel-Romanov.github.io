using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max_sum = 0;
            int min_sum = 0;
            for(int i = 1 ; i <= n ; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int sum = num1 + num2;

                if( i == 1)
                {
                    max_sum = sum;
                    min_sum = sum;
                }
                else if(sum > max_sum)
                {
                    max_sum = sum;
                }
                else if(sum < min_sum)
                {
                    min_sum = sum;
                }
                
            }
            if(min_sum == max_sum)
                {
                    Console.WriteLine("Yes , value=" + min_sum);
                }
                if(max_sum > min_sum)
                {
                    Console.WriteLine("No , maxdiff=" + (max_sum - min_sum));
                }
            //Console.WriteLine(max_sum + " " + min_sum);
        }
    }
}
