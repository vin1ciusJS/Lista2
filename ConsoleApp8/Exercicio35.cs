using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio35
    {
        public static void Executar()
        {
            Console.WriteLine("Estre progrma irar escrever os numeros de 1 a 100 e informar os multiplos de 10 ");
            Console.WriteLine();


            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
                if (i % 10 == 0)
                {
                    Console.WriteLine("O numero acima é múltiplo de 10");
                }
            }

            Console.ReadKey();

        }
    }
}
