using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            switch(n)
            {
                case 1: Console.WriteLine("EDNO"); break;
                case 2: Console.WriteLine("DVE"); break;
                case 3: Console.WriteLine("TRI");break;
                case 4: Console.WriteLine("ARSENAL");break;
                case 5: Console.WriteLine("PET");break;
                case 6: Console.WriteLine("MAN UNTD");break;
                case 7: Console.WriteLine("SEDEM");break;
                case 8: Console.WriteLine("OSEM");break;
                case 9: Console.WriteLine("DEVET"); break;
            }
        }
    }
}
