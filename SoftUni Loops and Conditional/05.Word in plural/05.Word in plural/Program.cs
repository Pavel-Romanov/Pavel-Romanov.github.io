using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();
            if (noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") || noun.EndsWith("sh") || noun.EndsWith("x") || noun.EndsWith("z"))
            {
                Console.WriteLine(noun + "es");
            }
            else if(noun.EndsWith("y"))
            {
                string noun1 = noun.Remove(noun.Length - 1);
                Console.WriteLine(noun1 + "ies");
            }
            else
            {
                Console.WriteLine(noun + "s");
            }
        }
    }
}
