using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_And_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] leftFold = new int[inputArray.Length / 4];
            int[] rightFold = new int[inputArray.Length / 4];
            int[] resultArray = new int[inputArray.Length / 2];

            //Fold LEFT and RIGHT side
            for (int i = 0; i < (inputArray.Length / 4); i++)
            {
                leftFold[i] = inputArray[(inputArray.Length / 4) - 1 - i];
                rightFold[i] = inputArray[inputArray.Length - 1 - i];
            }

            //SUM
            for (int i = 0; i < (inputArray.Length / 4); i++)
            {
                resultArray[i] = leftFold[i] + inputArray[inputArray.Length / 4 + i];
                resultArray[inputArray.Length / 4 + i] = rightFold[i] + inputArray[inputArray.Length / 2 + i];
            }

            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}
/*
2
1 2 3 4 5 6 7 8
*/