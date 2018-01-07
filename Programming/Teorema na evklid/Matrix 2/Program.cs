using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            while(M!=N)
            {
                if (M > N)
                    M = M - N;
                else
                    N = N - M;
            }
            Console.WriteLine(M);
        }
    }
}
