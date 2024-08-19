using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[10];
            int maiorValor = int.MinValue;
            int soma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o valor {i + 1}: ");
                bool inputValido = int.TryParse(Console.ReadLine(), out int valor);

                while (!inputValido || valor <= 0)
                {
                    Console.WriteLine("Erro: O valor deve ser um número inteiro positivo.");
                    Console.Write($"Digite o valor {i + 1}: ");
                    inputValido = int.TryParse(Console.ReadLine(), out valor);
                }

                valores[i] = valor;
                soma += valor;

                if (valor > maiorValor)
                {
                    maiorValor = valor;
                }
            }

            double media = (double)soma / 10;

            Console.WriteLine($"\nMaior valor: {maiorValor}");
            Console.WriteLine($"Soma dos valores: {soma}");
            Console.WriteLine($"Média aritmética: {media:F2}");

            Console.ReadKey();
        }
    }
}
