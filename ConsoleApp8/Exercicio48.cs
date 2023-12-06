using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio48
    {
        public static void Executar()
        {
            string[] nomes = new string[20];
            int[] idades = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Digite o nome da candidata " + (i + 1) + ": ");
                nomes[i] = Console.ReadLine();
                Console.Write("Digite a idade da candidata " + (i + 1) + ": ");
                idades[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Candidatas aptas a concorrer a uma vaga para a campanha milionária:");
            for (int i = 0; i < 20; i++)
            {
                if (idades[i] >= 18 && idades[i] <= 20)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
            Console.ReadKey();

        }
    }
}
