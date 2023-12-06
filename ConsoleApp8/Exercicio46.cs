using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio46
    {
        public static void Executar()
        {
            Console.Write("Digite o número de elementos nos vetores: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] x = new int[n];
            int[] y = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o elemento " + (i + 1) + " do vetor x: ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o elemento " + (i + 1) + " do vetor y: ");
                y[i] = Convert.ToInt32(Console.ReadLine());
            }

            int produtoEscalar = 0;
            for (int i = 0; i < n; i++)
            {
                produtoEscalar += x[i] * y[i];
            }

            Console.WriteLine("O produto escalar dos vetores x e y é: " + produtoEscalar);

            Console.ReadKey();

        }
    }
}
