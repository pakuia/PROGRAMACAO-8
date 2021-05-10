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
            int n, m, aux=0;

            Console.WriteLine("Digite um número inteiro:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número menor do que {0}:", n);
            m = int.Parse(Console.ReadLine());

            for (n = n; n > m; n--)
            {
                if (n % 2 == 1)
                {
                    aux++;
                }
            }
            Console.WriteLine("Existem {0} números impares entre {1} e {2}", aux, n, m);
            Console.ReadKey();
        }
    }
}
