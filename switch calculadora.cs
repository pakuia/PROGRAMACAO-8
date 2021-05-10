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
            int n1, n2;
            double res=0;
            char op, aux='S';

            while (aux == 'S')
            {
                Console.WriteLine("Digite um número:");
                n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite outro número:");
                n2 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite:\nA-Adição\nS-Subtração\nM-Multiplicação\nD-Divisão\nR-Resto de divisão");
                op = char.Parse((Console.ReadLine()).ToUpper());

                switch (op)
                {
                    case 'A':
                        res = n1 + n2;
                        break;
                    case 'S':
                        res = n1 - n2;
                        break;
                    case 'M':
                        res = n1 * n2;
                        break;
                    case 'D':
                        res = n1 / n2;
                        break;
                    case 'R':
                        res = n1 % n2;
                        break;
                    default:
                        Console.WriteLine("Operador inválido");
                        break;
                }
                Console.WriteLine("\nResposta: {0}", res);
                Console.WriteLine("\nDeseja executar novamente?\nS-sim ou N-não");
                aux = char.Parse((Console.ReadLine()).ToUpper());
            }

            Console.ReadKey();
        }
    }
}
