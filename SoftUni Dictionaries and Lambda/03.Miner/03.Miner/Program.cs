using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == "stop") { return; }
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, int> goods = new Dictionary<string, int>();

            while (true)
            {
                if (goods.ContainsKey(input))
                {
                    goods[input] += number;
                }
                else
                {
                    goods.Add(input, number);
                }
                input = Console.ReadLine();
                if (input.Equals("stop"))
                {
                    break;
                }
                number = int.Parse(Console.ReadLine());
            }
            foreach (var item in goods)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
