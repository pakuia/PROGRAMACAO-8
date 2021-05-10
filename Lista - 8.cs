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
            int w, x, y, z;
            bool total;

            Console.Write("Digite o valor de W: ");
            w = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de Y: ");
            y = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de Z: ");
            z = int.Parse(Console.ReadLine());

            total=(((x >= y) &&(z <= x)) ||((x == w) &&(y == z)) ||(!(x != w)));

            Console.WriteLine("((" + x + " >= " + y + ") AND (" + z + " <= " + x + ")) OR ((" + x + " == " + w + ") AND (" + y + " == " + z + ")) OR (NOT(" + x + " != " + w + ")) = "+total);

            Console.ReadKey();
        }
    }
}
