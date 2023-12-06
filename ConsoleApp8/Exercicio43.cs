using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio43
    {
        public static void Executar()
        {
            double total = 0;
            for (int i = 0; i < 64; i++)
            {
                double graosNoQuadro = Math.Pow(2, i);
                total += graosNoQuadro;
                Console.WriteLine("Quadro " + (i + 1) + ": " + graosNoQuadro + " grãos");
            }

            Console.WriteLine("O monge esperava receber um total de " + total + " grãos de trigo.");

        }
    }
}
