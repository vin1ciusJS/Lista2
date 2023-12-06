using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio57
    {
        public static void Executar()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            Console.Write("Vogais na frase: ");

            foreach (char c in frase)
            {
                if ("aeiouAEIOU".IndexOf(c) >= 0)
                {
                    Console.Write(c);
                }
            }

            Console.WriteLine();


        }
    }
}
