using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio56
    {
        public static void Executar()
        {
            Console.WriteLine("Este programa e capaz de analizar números de um vetor e anlizar os multiplos de 5 e d a quantidade de números pares");

            int[] vetor = new int[50];
            int contPares = 0, contMultiplos5 = 0;

            Console.WriteLine("Digite os elementos do vetor:");

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());

                if (vetor[i] % 2 == 0)
                {
                    contPares++;
                }

                if (vetor[i] % 5 == 0)
                {
                    contMultiplos5++;
                }
            }

            Console.WriteLine($"Quantidade de números pares: {contPares}");
            Console.WriteLine($"Quantidade de múltiplos de 5: {contMultiplos5}");


        }
    }
}
