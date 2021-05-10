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
            string nome1, nome2;

            Console.Write("Digite o nome da 1ª pessoa: ");
            nome1 = Console.ReadLine();

            Console.Write("\nDigite o nome da 2ª pessoa: ");
            nome2 = Console.ReadLine();


            Console.Write("\nMaiusculo:");
            Console.WriteLine(nome1.ToUpper());
            Console.WriteLine(nome2.ToUpper());

            Console.WriteLine("\nQuantidade de caracteres:");
            Console.WriteLine(nome1.Length);
            Console.WriteLine(nome2.Length);

            Console.WriteLine("\nOs 3 primeiros caracteres:");
            Console.WriteLine(nome1.Substring(0,3));
            Console.WriteLine(nome2.Substring(0,3));

            Console.ReadKey();
        }
    }
}
