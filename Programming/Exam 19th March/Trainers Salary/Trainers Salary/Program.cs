using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            double lec = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double money_for = budget / lec;
            var br_jelev = 0.00;
            var br_royal = 0.00;
            var br_roli = 0.00;
            var br_trofon = 0.00;
            var br_sino = 0.00;
            var br_drugi = 0.00;
            
            for(int i = 1 ; i <= lec ; i++)
            {
                string name = Console.ReadLine();
                switch(name)
                {
                    case "Jelev":  br_jelev++; break;
                    case "RoYaL":  br_royal++; break;
                    case "Roli":  br_roli++; break;
                    case "Trofon":  br_trofon++; break;
                    case "Sino": br_sino++; break;
                    default:  br_drugi++; break;
                }
            }
            double money_jelev = br_jelev * money_for;
            double money_roli = br_roli * money_for;
            double money_royal = br_royal * money_for;
            double money_trofon = br_trofon * money_for;
            double money_sino = br_sino * money_for;
            double money_drugi = br_drugi * money_for;

            Console.Write("Jelev salary: ");
            Console.Write( "{0:F2}",money_jelev);
            Console.Write(" lv");
            Console.WriteLine();
            Console.Write("RoYaL salary: ");
            Console.Write("{0:F2}",money_royal);
            Console.Write(" lv");
            Console.WriteLine();
            Console.Write("Roli salary: ");
            Console.Write("{0:F2}", money_roli);
            Console.Write(" lv");
            Console.WriteLine();
            Console.Write("Trofon salary: ");
            Console.Write("{0:F2}", money_trofon);
            Console.Write(" lv");
            Console.WriteLine();
            Console.Write("Sino salary: ");
            Console.Write("{0:F2}", money_sino);
            Console.Write(" lv");
            Console.WriteLine();
            Console.Write("Others salary: ");
            Console.Write("{0:F2}", money_drugi);
            Console.Write(" lv");
            Console.WriteLine();
        }
    }
}
/*
4
750
bai
bai
bai
Jelev
RoYal
*/