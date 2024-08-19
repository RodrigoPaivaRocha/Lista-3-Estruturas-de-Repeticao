using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char repetir;

            do
            {
                int numero;
                do
                {
                    Console.Write("Digite um valor para calcular o fatorial (não pode ser negativo): ");
                    bool inputValido = int.TryParse(Console.ReadLine(), out numero);

                    if (!inputValido || numero < 0)
                    {
                        Console.WriteLine("Erro: O valor deve ser um número inteiro não negativo.");
                    }

                } while (numero < 0);

                long fatorial = 1;
                for (int i = 1; i <= numero; i++)
                {
                    fatorial *= i;
                }

                Console.WriteLine($"\nFatorial de {numero} é: {fatorial}");

                do
                {
                    Console.Write("\nDeseja calcular o fatorial de outro número? (S/N): ");
                    repetir = Console.ReadLine().ToUpper()[0];

                    if (repetir != 'S' && repetir != 'N')
                    {
                        Console.WriteLine("Erro: Resposta inválida. Digite 'S' para Sim ou 'N' para Não.");
                    }

                } while (repetir != 'S' && repetir != 'N');

            } while (repetir == 'S');

            Console.WriteLine("Programa encerrado.");

            Console.ReadKey();
        }
    }
}
