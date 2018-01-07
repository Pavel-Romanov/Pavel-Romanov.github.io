using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calorie_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var total_calories = 0;
            int n = int.Parse(Console.ReadLine());
            string cheese = "cheese";
            string salami = "salami";
            string sauce = "tomato sauce";
            string pepper = "pepper";
            int br_cheese = 0;
            int br_salami = 0;
            int br_pepper = 0;
            int br_sause = 0;
            for(int i = 1 ; i <= n ; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                if(ingredient == cheese.ToLower())
                {
                    br_cheese++;
                    
                }
                if (ingredient == salami.ToLower())
                {
                    br_salami++;
                    
                }
                if (ingredient == pepper.ToLower())
                {
                    br_pepper++;
                   
                }
                if (ingredient == sauce.ToLower())
                {
                    br_sause++;

                }
                else continue;
            }
                total_calories += 500 * br_cheese;
                total_calories += 150 * br_sause;
                total_calories += 50 * br_pepper;
                total_calories += 600 * br_salami;
            
            Console.WriteLine("Total calories: " +  total_calories);
        }
    }
}
