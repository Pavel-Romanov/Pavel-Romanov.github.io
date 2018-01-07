using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishNameofLastDigit
{
    class Program
    {
        static void NameOfLastDigit(long n)
        {
            long last_digit = n % 10;
            switch(last_digit)
            {
                case 1: Console.WriteLine("one");break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
                case 0: Console.WriteLine("null"); break;

            }
        }
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            NameOfLastDigit(n);
        }
    }
}
