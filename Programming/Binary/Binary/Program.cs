using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while(n>0)
            {
               int k = n % 2;
               n = n / 2;
               Console.Write(k + " ");

            }
        }
    }
}
