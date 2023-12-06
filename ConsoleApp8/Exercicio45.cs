using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio45
    {
        public static void Executar()
        {
            Console.WriteLine("Este programa ira mostrar os numeros digitados em uma ordem invertida as digitadas!");
            Console.WriteLine();

            Console.Write("Digite o número de elementos na sequência: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o número na posição " + (i + 1) + ": ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Sequência na ordem inversa:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }

        }
    }
}
