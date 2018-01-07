using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[]
            {
                'a',
                'b',
                'c',
                'd',
                'e',
                'f',
                'g',
                'h',
                'i',
                'g',
                'k',
                'l',
                'm',
                'n',
                'o',
                'p',
                'q',
                'r',
                's',
                't',
                'u',
                'v',
                'w',
                'x',
                'y',
                'z',
            };
            string s = Console.ReadLine();
            var chars = s.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (chars[i] == alphabet[j])
                    {
                        Console.WriteLine(chars[i] + " -> " + j);
                    }
                }   
            }
        }
    }
}
