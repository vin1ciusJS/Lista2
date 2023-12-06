using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio21
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um número aleatório e o console ira indicar se e Negativo ou Positivo");
            Console.WriteLine();
            Console.WriteLine("digite um número qualquer");
            int Num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (Num < 0)
            {
                Console.WriteLine("O numero" + Num + " É um número negativo");
            }
            else
            {
                Console.WriteLine("O número" + Num + " É um numero Positivo");


            }
            Console.ReadKey();
        }
    }
}
