using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Digite um numero:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nO dobro de " + n + " é: " + 2 * n);

            Console.ReadKey();  
        }
    }
}
