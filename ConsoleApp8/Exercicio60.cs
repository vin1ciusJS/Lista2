using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio60
    {
        public static void Executar()
        {
            Console.Write("Digite o valor para x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor para y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            int quadrante = VerificaQuadrante(x, y);

            Console.WriteLine($"O ponto ({x}, {y}) está no quadrante {quadrante}.");
        }

        static int VerificaQuadrante(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else
            {
                return 4;
            }

        }
    }
}
