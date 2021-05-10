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
            string nome, cidade;
            int idade;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("\nDigite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite sua cidade: ");
            cidade = Console.ReadLine();

            Console.WriteLine("\nNome: " + nome + "\nIdade: " + idade + "\nCidade: " + cidade);

            Console.ReadKey();
        }
    }
}
