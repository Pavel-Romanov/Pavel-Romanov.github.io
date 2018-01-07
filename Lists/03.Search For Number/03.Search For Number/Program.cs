using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_For_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> List = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int[] array = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            List<int> ListClone = List;
            bool result = false;
            int x = ListClone.Count - (ListClone.Count - array[0]);

            for (int i = ListClone.Count ; i > x; i--)
            {
                ListClone.Remove(i); // Takes
            }
            for (int i = 0; i < array[1]; i++)
            {
                ListClone.Remove(ListClone[0]); // Maha
            }
            for (int i = 0; i < List.Count; i++)
            {
                
                if (array[2] == List[i])
                {
                    result = true;
                }
            }
          //  Console.WriteLine(string.Join(" ", ListClone));

            if (result == true)
            {
                Console.WriteLine("YES!");
            }
            else Console.WriteLine("NO!");
        }
    }
}
/*
12 412 123 21 654 34 65 3 23
7 4 21
*/