using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrases = 
            {
                "Excellent product.",
                "Such a great product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product.",
            };

            string[] events =
            {
                "Now I feel good.", 
                "I have succeeded with this product.",
                "Makes miracles.I am happy of the results!",
                "I cannot belive but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great."
            };

            string[] names =
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            string[] cities =
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };
            Random phrase = new Random();
            Random event1 = new Random();
            Random name = new Random();
            Random city = new Random();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    phrases[phrase.Next(0, phrases.Length)]
                + " " + events[event1.Next(0, events.Length)]
                + " " + names[name.Next(0, names.Length)]
                + " - " + cities[city.Next(0, cities.Length)]);
            }
            
        }
    }
}
