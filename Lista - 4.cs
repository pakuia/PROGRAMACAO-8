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
            int a,b,c;
            float total;

            Console.Write("Digite um numero para A:");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite um numero para B:");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite um numero para C:");
            c = int.Parse(Console.ReadLine());

            total = ((a * a) * 5 - c) / (b - a % 4);

            Console.WriteLine(a+"²*5-"+c+"/"+b+"-"+a+"%4="+total);

            Console.ReadKey();  
        }
    }
}
