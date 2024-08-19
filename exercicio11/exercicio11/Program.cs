using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            do
            {
                Console.Write("Digite a quantidade de valores (N), que deve ser positivo e menor que 20: ");
                bool inputValido = int.TryParse(Console.ReadLine(), out N);

                if (!inputValido || N <= 0 || N >= 20)
                {
                    Console.WriteLine("Erro: O valor de N deve ser um número inteiro positivo menor que 20.");
                }

            } while (N <= 0 || N >= 20);

            int[] valores = new int[N];
            int maiorValor = int.MinValue;
            int menorValor = int.MaxValue;
            int soma = 0;
            int positivos = 0;
            int negativos = 0;

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Digite o valor {i + 1}: ");
                bool inputValido = int.TryParse(Console.ReadLine(), out int valor);

                while (!inputValido)
                {
                    Console.WriteLine("Erro: O valor deve ser um número inteiro.");
                    Console.Write($"Digite o valor {i + 1}: ");
                    inputValido = int.TryParse(Console.ReadLine(), out valor);
                }

                valores[i] = valor;
                soma += valor;

                if (valor > maiorValor)
                {
                    maiorValor = valor;
                }

                if (valor < menorValor)
                {
                    menorValor = valor;
                }

                if (valor > 0)
                {
                    positivos++;
                }
                else if (valor < 0)
                {
                    negativos++;
                }
            }

            double media = (double)soma / N;
            double porcentagemPositivos = (double)positivos / N * 100;
            double porcentagemNegativos = (double)negativos / N * 100;

            Console.WriteLine($"\nMaior valor: {maiorValor}");
            Console.WriteLine($"Menor valor: {menorValor}");
            Console.WriteLine($"Soma dos valores: {soma}");
            Console.WriteLine($"Média aritmética: {media:F2}");
            Console.WriteLine($"Porcentagem de valores positivos: {porcentagemPositivos:F2}%");
            Console.WriteLine($"Porcentagem de valores negativos: {porcentagemNegativos:F2}%");

            Console.ReadKey();
        }
    }
}
