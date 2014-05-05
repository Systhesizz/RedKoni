using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedKoni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadKey();
            Console.Clear();

            Console.Write("3,");

            int e;
            double l = 0;

            for (e = 1; ; e++)
            {
                int k = e;
                l = (16 ^ (-k)) * (4 / (8 * k + 1) - 2 / (8 * k + 4) - 1 / (8 * k + 5) - 1 / (8 * k + 6));
                Console.Write(l);
            }
            Console.ReadKey();
        }
    }
}
