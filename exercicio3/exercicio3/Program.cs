using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sexo;

            do
            {
                Console.Write("Digite o sexo (F/M): ");
                sexo = char.ToUpper(Console.ReadLine()[0]);
            } while (sexo != 'F' && sexo != 'M');

            Console.WriteLine($"Sexo digitado: {sexo}");

            Console.ReadKey();
        }
    }
}
