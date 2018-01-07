using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studio_money = 0.00;
            double double_money = 0.00;
            double suite_money = 0.00;
           // double discount = 0.00;

            switch(month)
            {
                case "May": 
                    studio_money = nights * 50;
                    if(nights > 7)
                    {
                        studio_money = studio_money - studio_money * 0.05;
                    }
                    double_money = nights * 65;
                    suite_money = nights * 75;break;
                case "October":
                    studio_money = (nights-1) * 50;
                    if (nights > 7)
                    {
                        studio_money = studio_money - studio_money * 0.05;
                    }
                    double_money = nights * 65;
                    suite_money = nights * 75; break;
                case "June":
                    studio_money = nights * 60;
                    double_money = nights * 72;
                    if(nights > 14)
                    {
                        double_money = double_money - double_money * 0.10;
                    }
                    suite_money = nights * 82; break;
                case "September":
                    studio_money = (nights - 1) * 60;
                    double_money = nights * 72;
                    if (nights > 14)
                    {
                        double_money = double_money - double_money * 0.10;
                    }
                    suite_money = nights * 82; break;
                case "July":
                    studio_money = nights * 68;
                    double_money = nights * 77;
                    suite_money = nights * 89;
                    if(nights > 14)
                    {
                        suite_money = suite_money - suite_money * 0.15;
                    }
                        break;
                case "August":
                    studio_money = nights * 68;
                    double_money = nights * 77;
                    suite_money = nights * 89;
                    if(nights > 14)
                    {
                        suite_money = suite_money - suite_money * 0.15;
                    }break;
                case "December":
                    studio_money = nights * 68;
                    double_money = nights * 77;
                    if(nights > 14)
                    {
                        suite_money = suite_money - suite_money * 0.15;
                    }
                    suite_money = nights * 89; break;
            }
            Console.Write("Studio: "); Console.Write("{0:F2}", studio_money); Console.Write(" lv."); Console.WriteLine();
            Console.Write("Double: "); Console.Write("{0:F2}", double_money); Console.Write(" lv."); Console.WriteLine();
            Console.Write("Suite: " ); Console.Write("{0:F2}", suite_money); Console.Write(" lv."); Console.WriteLine();
        }
    }
}
