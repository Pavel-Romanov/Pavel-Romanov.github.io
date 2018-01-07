using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01.Practise_integer_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            double days = Math.Floor(years * 365.2422);
            double hours = days * 24;
            double minutes = hours * 60;
            ulong minutes1 = Convert.ToUInt64(minutes);
            ulong seconds = minutes1 * 60;
            ulong seconds1 = Convert.ToUInt64(seconds); 
            ulong millis = seconds1 * 1000;
            ulong micro = millis * 1000;
            ulong nano = micro * 1000;
            Decimal nano1 = Convert.ToDecimal(nano);
            Console.Write(centuries + " centuries = " + years + " years = " + days +" days = " + hours + " hours = " + minutes1 + " minutes = " + seconds1 + " seconds = " + millis + " milliseconds = " + micro + " microseconds = " + nano1 + " nanoseconds");
           
        }
    }
}
