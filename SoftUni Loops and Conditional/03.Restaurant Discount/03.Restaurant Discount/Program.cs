using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int people = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall = "N/A";
            var price_per_person = 0.00;
            var money = 0.00;

            if(people < 50)
            {
                money += 2500;
                hall = "Small Hall";
            }
            else if (people >= 50 && people < 100)
            {
                money += 5000;
                hall = "Terrace";
            }
            else if (people >= 100 && people <= 120)
            {
                money += 7500;
                hall = "Great Hall";
            }
            else { Console.WriteLine("We do not have an appropriate hall."); return; }

            if(package == "Normal" )
            {
                money += 500;
                var discount = money - money * 0.5;
                price_per_person = discount / people;
                Console.WriteLine("We can offer you the " + hall);
                Console.Write("The price per person is "); Console.Write("{0:F2}", price_per_person);Console.Write("$");
                Console.WriteLine();
            }
            if (package == "Gold")
            {
                money += 750;
                var discount = money - money * 0.10;
                price_per_person = discount / people;
                Console.WriteLine("We can offer you the " + hall);
                Console.Write("The price per person is "); Console.Write("{0:F2}", price_per_person); Console.Write("$");
                Console.WriteLine();
            }
            if (package == "Platinum")
            {
                money += 1000;
                var discount = money - money * 0.15;
                price_per_person = discount / people;
                Console.WriteLine("We can offer you the " + hall);
                Console.Write("The price per person is "); Console.Write("{0:F2}", price_per_person); Console.Write("$");
                Console.WriteLine();
            }
            
        }
    }
}
