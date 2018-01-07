using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;        
            int match_counter = 0;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            for(int i = b ; i >= a ; i--)
            {
                for(int j = b ; j >= a ; j--)
                {
                    counter++;
                    if ((i + j) == magic)
                    {
                        match_counter++;
                        Console.WriteLine("Number found! " + i + " + " + j + " = " + magic);
                        return;
                    }
                }
            }
            if (match_counter == 0)
            {
                Console.WriteLine(counter + " combinations - neither equals " + magic);
            }
        }
    }
}
