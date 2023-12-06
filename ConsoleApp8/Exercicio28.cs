using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio28
    {
        public static void Executar()
        {
            Console.WriteLine("Este progama ira gerar os numeos impares de 100 a 200");
            Console.WriteLine();

            for (int i = 100; i <= 200; i++)  //luping de 100 a 200
            {
                if (i % 2 != 0) // conferir se o numero e par
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();

        }
    }
}
