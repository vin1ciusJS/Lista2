using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio49
    {
        public static void Executar()
        {
            Console.Write("Digite o número de componentes nos vetores: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 50)
            {
                Console.WriteLine("O número de componentes não pode ser maior que 50.");
                return;
            }

            int[] V1 = new int[n];
            int[] V2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o componente " + (i + 1) + " do vetor V1: ");
                V1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o componente " + (i + 1) + " do vetor V2: ");
                V2[i] = Convert.ToInt32(Console.ReadLine());
            }

            int contagem = 0;
            for (int i = 0; i < n; i++)
            {
                if (V1[i] == V2[i])
                {
                    contagem++;
                }
            }

            Console.WriteLine("V1 e V2 possuem valores idênticos nas mesmas posições " + contagem + " vezes.");

            Console.ReadKey();

        }
    }
}
