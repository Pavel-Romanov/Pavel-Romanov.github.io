using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumbersInReversedOrder
{
   
    class Program
    {
        static long ReversedNumber(long n)
        {
            long left = n;
            long rev = 0;
            while (left > 0)
            {
                long r = left % 10;
                rev = rev * 10 + r;
                left = left / 10;
            }
            return rev;
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Console.WriteLine( Reverse(n) ); 
        }
    }
}
