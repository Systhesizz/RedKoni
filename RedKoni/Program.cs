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

            int k;

            for (k=1; ; k++)
            {
                Console.Write(((2 * k) ^ 2) / ((2 * k - 1) * (2 * k + 1)));
            }
        }
    }
}
