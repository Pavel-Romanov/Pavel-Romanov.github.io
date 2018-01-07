using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello_Name
{
    class Program
    {
        static void Name(string n)
        {
            Console.WriteLine("Hello, {0}!" , n);
        }
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Name(n);
        }
    }
}
