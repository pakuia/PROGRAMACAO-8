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
            int a, b, aux;

            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            aux = a;
            a = b;
            b = aux;
            aux = 0;

            Console.Write("\nInversão:");
            Console.WriteLine("\na="+a);
            Console.WriteLine("b="+b);

            Console.ReadKey();
        }
    }
}
