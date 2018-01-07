using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trying_out_dimensional_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] array = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
               for (int col = 0; col < cols; col++)
               {
                    array[row, col] = int.Parse(Console.ReadLine());
               }
            }
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write("{0} , " , array[row, col]);
                  
                } 
                Console.WriteLine();
            }
        }
    }
}
