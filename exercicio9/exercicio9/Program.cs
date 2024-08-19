using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c;

            Console.Write("Os 30 primeiros valores da série de Fibonacci são: ");
            Console.Write($"{a}, {b}");

            for (int i = 3; i <= 30; i++)
            {
                c = a + b;
                Console.Write($", {c}");
                a = b;
                b = c;
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
