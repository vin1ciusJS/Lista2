using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio53
    {
        public static void Executar()
        {
            Console.Write("Digite o número de voltas: ");
            int N = Convert.ToInt32(Console.ReadLine());

            double[] tempos = new double[N];
            double somaTempos = 0, melhorTempo = double.MaxValue;
            int voltaMelhorTempo = 0;

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Digite o tempo da volta {i + 1}: ");
                tempos[i] = Convert.ToDouble(Console.ReadLine());
                somaTempos += tempos[i];

                if (tempos[i] < melhorTempo)
                {
                    melhorTempo = tempos[i];
                    voltaMelhorTempo = i + 1;
                }
            }

            double tempoMedio = somaTempos / N;

            Console.WriteLine($"Melhor tempo: {melhorTempo}");
            Console.WriteLine($"Volta do melhor tempo: {voltaMelhorTempo}");
            Console.WriteLine($"Tempo médio: {tempoMedio}");

        }
    }
}
