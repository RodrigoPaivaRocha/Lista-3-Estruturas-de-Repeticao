using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, a, b;

            Console.Write("Digite o valor de X (para a tabuada): ");
            x = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Digite o valor de A (intervalo mínimo): ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor de B (intervalo máximo, deve ser maior que A): ");
                b = int.Parse(Console.ReadLine());
            } while (b <= a);

            for (int i = b; i >= a; i--)
            {
                Console.WriteLine($"{x} x {i} = {x * i}");
            }

            Console.ReadKey();
        }
    }
}
