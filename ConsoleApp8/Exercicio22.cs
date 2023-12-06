using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio22
    {
        public static void Executar()
        {
            Console.WriteLine("Informe um número e o console irá informar se foi armazenado em A ou B");
            Console.WriteLine();

            Console.Write("Digite um número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int? A = null;
            int? B = null;

            if (num >= 0)
            {
                A = num;
                Console.WriteLine("O NÚMERO foi armazenado em A");
            }
            else
            {
                B = num;
                Console.WriteLine("O NÚMERO foi armazenado em B");
            }

            if (A.HasValue)
                Console.WriteLine("A = " + A.Value);
            else
                Console.WriteLine("A não foi definido");

            if (B.HasValue)
                Console.WriteLine("B = " + B.Value);
            else
                Console.WriteLine("B não foi definido");

        }
    }
}
