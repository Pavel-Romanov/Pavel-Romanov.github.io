using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = 0;
            int bestStart = 0;
            int length = 0;
            int bestLength = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[start] == numbers[i])
                {
                    length++;
                    if (length > bestLength)
                    {
                        bestLength = length;
                        bestStart = start;
                    }
                }
                else
                {
                    start++;
                    i = start;
                    length = 0;
                }
            }
            for (int i = 0; i <= bestLength; i++)
            {
                Console.Write(numbers[bestStart + i] + " ");
            }
        }
    }
}
