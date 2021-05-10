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
            int n, m;

            Console.WriteLine("Digite um número inteiro:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número menor do que {0}:", n);
            m = int.Parse(Console.ReadLine());

            Console.WriteLine("Número impares entre {0} e {1}:",n,m);
            for (n=n;n>=m;n--)
            {
                if (n % 2 == 1)
                {
                    Console.WriteLine("{0}", n);
                }
            }
            Console.ReadKey();
        }
    }
}
