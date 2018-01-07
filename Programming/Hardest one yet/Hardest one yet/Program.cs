using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardest_one_yet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            int maxCount = 0;
            int value = 0;
            for(int i = 0 ; i < array.Length ; i++)
            {
                int currentcount = 0;
                for(int j = i ; j<array.Length;j++)
                {
                    if (array[i] == array[j])
                    {
                        currentcount++;
                        if (maxCount < currentcount)
                    {
                        maxCount = currentcount;
                        value = array[i];
                    }
                }
                else
                {
                    break;
                }
                    }
                }
             Console.WriteLine("Max length = {0} and value is {1}", maxCount, value);
    }
        }
    }
