using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Prime_Bullshit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] array = new bool[n + 1];
            for (int i = 0; i <= n; i++)
            {
                array[i] = true;
            }
            array[0] = false;
            array[1] = false;

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == true)
                {
                    for(int j = 2;  (j * i) <= n; j++)
                    {
                        array[j * i] = false;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == true)
                    Console.Write(i + " ");
            }
        }
    }
}
