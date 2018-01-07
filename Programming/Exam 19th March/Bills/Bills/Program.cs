using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            var months = double.Parse(Console.ReadLine());
            var voda = 20.00;
            var internet = 15.00;
            var tok = 1.00;
            var tok_sum = 0.00;
            var drygi_sum = 0.00;
            var voda_total = months * voda;
            var internet_total = months * internet;
 
            for(int i = 1; i <= months ; i++)
            {
                tok = double.Parse(Console.ReadLine());
                tok_sum+=tok;
                var drygi = (tok + voda + internet) + 0.2 * (tok + voda + internet);
                drygi_sum+=drygi;
            }
            var average = (tok_sum + (months * voda) + (months * internet) + drygi_sum) / months;

            Console.Write("Electricity: ");
            Console.Write("{0:F2}", tok_sum);
            Console.Write(" lv");
            Console.WriteLine();
            Console.Write("Water: ");
            Console.Write("{0:F2}", voda_total);
            Console.Write(" lv");
            Console.WriteLine();
            Console.Write("Internet: ");
            Console.Write("{0:F2}", internet_total);
            Console.Write(" lv");
            Console.WriteLine();
            Console.Write("Other: ");
            Console.Write("{0:F2}", drygi_sum);
            Console.Write(" lv");
            Console.WriteLine();
            Console.Write("Average: ");
            Console.Write("{0:F2}", average);
            Console.Write(" lv");
            Console.WriteLine();
            
        }
    }
}
/*
5
68.63
89.25
132.53
93.53
63.22
*/