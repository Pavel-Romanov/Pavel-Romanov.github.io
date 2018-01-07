using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxincreasingsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for(int i = 0 ; i < n ; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxCount = 0;
            int startIndex = 0;
            for (int i = 0; i < n; i++)
            {
                int currentCount = 0;
                for (int j = i; j < n - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        currentCount++;
                        if (maxCount < currentCount)
                        {
                            maxCount = currentCount;
                            startIndex = array[i];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int count = 0; count <= maxCount; count++)
            {
                Console.Write("{0} ", array[startIndex + count]);
            }
            Console.WriteLine();

        }
    }
}
