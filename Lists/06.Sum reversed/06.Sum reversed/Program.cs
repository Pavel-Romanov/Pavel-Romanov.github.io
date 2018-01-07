using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_reversed
{
    class Program
    {
        static int reverse(int n)
        {
            int result = 0;     
            int digit = 0;
            while (n > 0)
            {         
                digit = n % 10; 
                result = (result * 10) + digit;
                n = n / 10;
            }
            return result;
        }

        static void Main(string[] args)
        {
            List<int> num = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int sum = 0;
            for (int i = 0; i < num.Count; i++)
            {
                sum += reverse(num[i]);
            }
            Console.WriteLine(sum);

        }
    }
}
