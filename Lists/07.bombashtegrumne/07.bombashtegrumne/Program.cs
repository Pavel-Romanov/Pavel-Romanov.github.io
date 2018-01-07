using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.bombashtegrumne
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> List = Console.
                ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> array = Console.
                ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < List.Count; i++)
            {
                if(array[0] == List[i])
                {
                    int x = 2 * array[1] + 1;
                    if (x > List.Count - 1)
                    {
                        x = List.Count - 1;
                    }
                    List.RemoveRange(List[i - 1 - array[1]], x);
                }
            }
            int sum = 0;
            for (int i = 0; i < List.Count; i++)
            {
                sum += List[i];
            }
            Console.WriteLine(sum);
        }
    }
}
