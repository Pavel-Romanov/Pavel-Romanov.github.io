using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSeqInc_13._05._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int l = numbers.Length;

            MaxIncSequence(numbers, l);
        }

        static void MaxIncSequence(int[] numbers, int l)
        {
            int lenght = 0;
            int startCurrSeq = 0;
            int maxlenght = 0;
            int startMaxSeq = 0;

            for (int i = 1; i < l; i++)
            {
                if (numbers[i] - numbers[i - 1] >= 1)
                {
                    lenght++;
                    startCurrSeq = i - lenght;

                    if (lenght > maxlenght)
                    {
                        maxlenght = lenght;
                        startMaxSeq = startCurrSeq;
                    }
                }
                else
                {
                    lenght = 0;
                }
            }
            for (int iWrite = startMaxSeq; iWrite <= (startMaxSeq + maxlenght); iWrite++)
            {
                Console.Write(numbers[iWrite] + " ");
            }
            Console.WriteLine();
        }
    }
}