using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            string lines = Console.ReadLine();
            while (lines != "END")
            {
                var tokens = lines.Split();
                var command = tokens[0];
                if (command == "A")
                {
                    if (phonebook.ContainsKey(tokens[1]))
                    {
                        phonebook[tokens[1]] = tokens[2];
                    }
                    else
                        phonebook.Add(tokens[1], tokens[2]);
                }
                if (command == "S")
                {
                    if (!phonebook.ContainsKey(tokens[1]))
                    {
                        Console.WriteLine($"Contact {tokens[1]} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{tokens[1]} -> {phonebook[tokens[1]]}");
                    }
                }
                if (command == "ListAll")
                {
                    foreach (KeyValuePair<string, string> pair in phonebook)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }
                }

                lines = Console.ReadLine();
            }
            //Console.WriteLine(string.Join(" ", phonebook));
        }
    }
}
/*
A nakov 123
A pavel 231
A andery 2121
*/
