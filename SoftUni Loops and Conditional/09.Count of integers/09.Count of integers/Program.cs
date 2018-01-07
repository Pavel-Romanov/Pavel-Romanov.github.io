using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_of_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int br = 0;
            while (true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    br++;
                }
                catch (Exception ex)
                {
                    break;
                }
            }
            Console.WriteLine(br);
        }
    }
}
