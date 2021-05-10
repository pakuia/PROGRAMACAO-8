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
            int n=0, i, aux=0;

            for (i=1; i<=15; i++)
            {
                Console.WriteLine("Digite um número inteiro:");
                if (i == 1)
                {
                    n = int.Parse(Console.ReadLine());
                }
                else
                {
                    aux = int.Parse(Console.ReadLine());
                    if (aux > n)
                    {
                        n = aux;
                    }
                    aux = 0;
                }
            }
            Console.WriteLine("O maior número digitado é o {0}",  n);
            Console.ReadKey();
        }
    }
}
