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
            float reais, dolar, total;

            Console.Write("Digite o valor em reais: ");
            reais = float.Parse(Console.ReadLine());

            Console.Write("\nDigite a cotação do dolar: ");
            dolar= float.Parse(Console.ReadLine());

            total = reais * dolar;

            Console.Write("\nA conversão para dolar dará: {0:N2}",total);

            Console.ReadKey();
        }
    }
}
