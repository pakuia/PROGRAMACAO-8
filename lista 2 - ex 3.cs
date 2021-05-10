using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,m=1,i;

            Console.WriteLine("Digite um número para saber sua tabuada:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nTabuada do número {0}:", n);
            for (i = 1; i <= 10; i++)
            {
                m = i * n;
                Console.WriteLine("{0}",m);
            }
            Console.ReadKey();
        }
    }
}
