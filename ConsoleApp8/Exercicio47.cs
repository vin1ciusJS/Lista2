using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio47
    {
        public static void Executar()
        {
            int[] vetor = new int[10];
            int x, maiores = 0, menores = 0, iguais = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite o número na posição " + (i + 1) + ": ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Digite o número X: ");
            x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] > x)
                {
                    maiores++;
                }
                else if (vetor[i] < x)
                {
                    menores++;
                }
                else
                {
                    iguais++;
                }
            }

            Console.WriteLine("Números maiores que X: " + maiores);
            Console.WriteLine("Números menores que X: " + menores);
            Console.WriteLine("Números iguais a X: " + iguais);

        }
    }
}
