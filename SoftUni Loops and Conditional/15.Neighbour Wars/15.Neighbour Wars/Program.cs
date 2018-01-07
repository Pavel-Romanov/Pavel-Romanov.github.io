using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int gosho_health = 100;
            int pesho_health = 100;
            int br = 0;
            int pesho_dmg = int.Parse(Console.ReadLine());
            int gosho_dmg = int.Parse(Console.ReadLine());
            bool win = true;

            while(win)
            {
                br++;
                if(i % 2 == 1)
                {
                    gosho_health -= pesho_dmg;
                    if (gosho_health <= 0)
                    {
                        win = false;
                        Console.WriteLine("Pesho won in " + br + "th" + " round.");
                        return;
                    }
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to " + gosho_health  + " health.");
                }
                if (i % 2 == 0)
                {
                    pesho_health -= gosho_dmg;
                    if (pesho_health <= 0)
                    {
                        win = false;
                        Console.WriteLine("Gosho won in " + br + "th" + " round.");
                        return;
                    }
                   
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to " + pesho_health + " health.");
                }
                if(i % 3 == 0)
                {
                    gosho_health += 10;
                    pesho_health += 10;
                }
                i++;
 
            }
        }
    }
}
