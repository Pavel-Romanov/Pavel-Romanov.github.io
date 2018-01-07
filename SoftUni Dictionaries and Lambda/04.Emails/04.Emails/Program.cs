using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            string name = Console.ReadLine();
            while (name != "stop")
            {
                string email = Console.ReadLine();
                string output = email.Substring(email.Length - 2, 2); // last two letters
                if (output != "us" && output != "uk")
                {
                    emails.Add(name, email);
                }
                name = Console.ReadLine();
            }
            foreach (var item in emails)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
/*
pavel
pavel@abv.bg
yana
yanak@abv.bg
tyson
tyson@2yahho.us
*/