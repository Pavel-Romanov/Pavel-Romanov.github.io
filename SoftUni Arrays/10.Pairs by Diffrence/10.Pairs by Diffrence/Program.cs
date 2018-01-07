using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Diffrence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diffrence = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if ((array[i] - array[j] == diffrence) || (array[i] - array[j] == -diffrence))
                    {
                        count++;
                    }
                } 
            }
            Console.WriteLine(count/2);
        }
    }
}
