using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_ove
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if(a > b && a > c)
            {
                Console.Write(a + " ");

                if (b > c) Console.Write(b + " " + c);
                
                else if (c > b)Console.Write(c + " " + b);

            }
            if (b > a && b > c)
            {
                Console.Write(b + " ");

                if (a > c) Console.Write(a + " " + c);
                
                else if (c > a)Console.Write(c + " " + a);

            }
            if (c > b && c > a)
            {
                Console.Write(c + " ");

                if (a > b) Console.Write(a + " " + b);

                else if (b > a) Console.Write(b + " " + a);

            }
        }
    }
}
