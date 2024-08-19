using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiroValor, segundoValor;

            Console.Write("Digite o primeiro valor: ");
            primeiroValor = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Digite o segundo valor (deve ser maior que o primeiro): ");
                segundoValor = int.Parse(Console.ReadLine());
            } while (segundoValor <= primeiroValor);

            Console.WriteLine($"Primeiro valor: {primeiroValor}, Segundo valor: {segundoValor}");

            Console.ReadKey();
        }
    }
}
