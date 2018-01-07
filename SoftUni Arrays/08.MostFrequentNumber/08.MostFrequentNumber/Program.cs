using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int most_wanted = 0;
            int br = 1;
            int start = 0;
            int bestnum = 0;

            for (int i = 1; i < array.Length; i++)
            {
                most_wanted = array[start];
                if(array[i] == most_wanted)
                {
                    bestnum = most_wanted;
                }
                else
                {
                    start++;
                    br = 0;
                }
            }
            Console.WriteLine(bestnum);
        }
    }
}
