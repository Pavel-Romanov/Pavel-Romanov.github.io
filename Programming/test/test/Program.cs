using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
             int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

          DateTime hm = DateTime.ParseExact("{h}:{m}", "H:m", null);
 
          hm = hm.AddMinutes(15);        

          Console.WriteLine(hm.ToString("H:mm"));
        }
    }
}
