using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingridients
{
    class Program
    {
        static void Main(string[] args)
        {
            string bake = "Bake!";
            int br = 0;
            string a = " ";
            while(true)
            {
                a = Console.ReadLine();
                if(a == bake)
                {
                    break; 
                }
                Console.WriteLine("Adding ingredient " + a + ".");
                br++;
            }
            Console.WriteLine("Preparing cake with " + br + " ingredients.");
        }
    }
}
