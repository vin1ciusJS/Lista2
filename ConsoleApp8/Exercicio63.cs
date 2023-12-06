using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio63
    {
        public static void Executar()
        {
            Console.Write("Digite um número inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            string resultado = Verifica(numero);

            Console.WriteLine($"O número {numero} é {resultado}.");
        }

        static string Verifica(int numero)
        {
            if (numero % 2 == 0)
            {
                return "PAR";
            }
            else
            {
                return "ÍMPAR";
            }

        }
    }
}
