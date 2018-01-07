using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            string startDateText = Console.ReadLine();
            string endDateText = Console.ReadLine();

            DateTime startDate = DateTime.ParseExact(startDateText, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(endDateText, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            int holidayCounter = 0;

            DateTime[] daysOff = new DateTime[12];

            daysOff [0] = new DateTime(4, 01, 01);
            daysOff [1] = new DateTime(4, 03, 03);
            daysOff [2] = new DateTime(4, 05, 01);
            daysOff [3] = new DateTime(4, 05, 06);
            daysOff [4] = new DateTime(4, 05, 24);
            daysOff [5] = new DateTime(4, 09, 06);
            daysOff [6] = new DateTime(4, 09, 22);
            daysOff [7] = new DateTime(4, 11, 01);
            daysOff [9] = new DateTime(4, 12, 24);
            daysOff [10] = new DateTime(4, 12, 25);
            daysOff[11] = new DateTime(4, 12, 26);

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                DayOfWeek day = i.DayOfWeek;

                DateTime temp = new DateTime(4, i.Month, i.Day);

                if (!daysOff.Contains(temp) && (!day.Equals(DayOfWeek.Saturday) && !day.Equals(DayOfWeek.Sunday)))
                {
                    holidayCounter++;
                }
            }
            Console.WriteLine(holidayCounter);
        }
    }
}
/*
11-04-2016
14-04-2016
*/