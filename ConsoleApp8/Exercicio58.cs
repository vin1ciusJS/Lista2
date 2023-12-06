using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio58
    {
        public static void Executar()
        {
            Console.Write("Digite a quantidade de números que você deseja inserir: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[quantidade];
            int soma = 0, maior = int.MinValue;

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                soma += numeros[i];

                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
            }

            double media = (double)soma / quantidade;

            Console.WriteLine($"A média dos números é {media}.");
            Console.WriteLine($"O maior número é {maior}.");

        }
    }
}
