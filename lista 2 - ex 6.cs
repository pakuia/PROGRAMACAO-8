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
            int total=0, n=0, i;
            double media;

            for (i=1; i<=10; i++)
            {
                Console.WriteLine("Digite a {0}� nota:", i);
                n = int.Parse(Console.ReadLine());
                total += n; 
                if (n < 0 || n >10)
                {
                    Console.WriteLine("Nota inv�lida!");
                }
                n=0;            }
            media = total / 10;
            Console.WriteLine("A m�dia das 10 notas digitada � igual a {0}", media);
            Console.ReadKey();
        }
    }
}