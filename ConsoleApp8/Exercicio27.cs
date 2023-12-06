using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio27
    {
        public static void Executar()
        {
            Console.Write("Digite a quantidade de números que você deseja processar: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite um número: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                long fatorial = Fatorial(numero);

                Console.WriteLine("O fatorial de " + numero + " é " + fatorial);
            }
        }

        static long Fatorial(int numero)
        {
            long fatorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i;
            }

            return fatorial;

        }
    }
}
