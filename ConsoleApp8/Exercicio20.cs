using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio20
    {
        public static void Executar()
        {
            Console.WriteLine("Exibe o menor valor lido multiplicado pelo maior e o maior valor dividido pelo menor. ");

            int a, b, c;

            Console.Write("Digite um valor maior que zero para a: ");
            a = int.Parse(Console.ReadLine());
            while (a <= 0)
            {
                Console.Write("Valor inválido. Digite um valor maior que zero para a: ");
                a = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite um valor maior que zero para b: ");
            b = int.Parse(Console.ReadLine());
            while (b <= 0)
            {
                Console.Write("Valor inválido. Digite um valor maior que zero para b: ");
                b = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite um valor maior que zero para c: ");
            c = int.Parse(Console.ReadLine());
            while (c <= 0)
            {
                Console.Write("Valor inválido. Digite um valor maior que zero para c: ");
                c = int.Parse(Console.ReadLine());
            }

            int menor = Math.Min(a, Math.Min(b, c));
            int maior = Math.Max(a, Math.Max(b, c));

            Console.WriteLine("O menor valor multiplicado pelo maior é " + (menor * maior));
            Console.WriteLine("O maior valor dividido pelo menor é " + ((double)maior / menor));

        }
    }
}
