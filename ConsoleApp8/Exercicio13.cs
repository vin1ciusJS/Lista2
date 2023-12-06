using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio13
    {
        public static void Executar()
        {
            Console.WriteLine("Informe três numeros e o console irá mostra-los em ordem DECRESCENTE");
            Console.WriteLine();

            Console.Write("Digite o primeiro número inteiro: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número inteiro: ");
            int num3 = int.Parse(Console.ReadLine());

            int[] numeros = new int[] { num1, num2, num3 }; // new int[] fara que seja inserido dentro [] os numeros na hora de mostrar na tela

            // abaixo os numeros serão ordenados e depois de ordenados será invertido para mostrar de forma inversa.

            Array.Sort(numeros); // ordena os elementos do array "numeros" em ordem crescente.
                                 // Isso significa que os números no array serão reorganizados de modo que o menor número fique na primeira
                                 // posição e o maior número na última.

            Array.Reverse(numeros); //inverte a ordem em que os elementos aparecem no array

            Console.WriteLine("Os números em ordem decrescente são: " + numeros[0] + ", " + numeros[1] + ", " + numeros[2]);

        }
    }
}
