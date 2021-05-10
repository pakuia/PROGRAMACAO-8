using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 1; i <= 100; i++)
            {
                Console.WriteLine("{0}", i);
                if (i % 10 == 0)
                {
                    Console.WriteLine("{0} é multiplo de 10!", i);
                }
            }
            Console.ReadKey();
        }
    }
}