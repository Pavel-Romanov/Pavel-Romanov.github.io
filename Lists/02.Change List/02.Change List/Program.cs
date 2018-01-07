using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string line = Console.ReadLine(); 

            while (!(line == "Even" || line == "Odd"))
            {
                var tokens = line.Split();
                var command = tokens[0];

                if(command == "Delete")
                {
                    var neshto = int.Parse(tokens[1]);
                    list.RemoveAll(y => neshto == y);
                }
                if(command == "Insert")
                {
                    var drygo = int.Parse(tokens[1]);
                    var treto = int.Parse(tokens[2]);
                    list.Insert(treto, drygo);
                }
                line = Console.ReadLine();
            }
            if(line == "Odd")
            {
                for (int i = 0; i <= list.Count - 1; i++)
                {
                    if(list[i] % 2 == 0)
                    {
                        list.Remove(list[i]);
                    }
                }
            }
            if (line == "Even")
            {
                for (int i = 0; i <= list.Count - 1; i++)
                {
                    if (list[i] % 2 == 1)
                    {
                        list.Remove(list[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
