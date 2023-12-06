using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio34
    {
        public static void Executar()
        {
            double numero;
            double maior = double.MinValue; //variavel para receber o número maior
            double menor = double.MaxValue;//variavel para receber o número menor

            Console.WriteLine("Digite um número positivo (ou um número negativo para terminar):");
            numero = Convert.ToDouble(Console.ReadLine());

            while (numero >= 0)
            {
                if (numero > maior)
                {
                    maior = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }

                Console.WriteLine("Digite outro número positivo (ou um número negativo para terminar):");
                numero = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("O maior número digitado foi " + maior + ".");
            Console.WriteLine("O menor número digitado foi " + menor + ".");

            Console.ReadKey();

        }
    }
}
