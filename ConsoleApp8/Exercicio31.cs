using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio31
    {
        public static void Executar()
        {
            Console.WriteLine("informe numeros pares e impares e no final o progama ira dar a soma dos pares e dos impares");
            Console.WriteLine("para sair basta digitar um numero negativo");
            Console.WriteLine();

            int somaPares = 0;
            int somaImpares = 0;
            int numero;

            Console.WriteLine("Digite um número positivo (ou um número negativo para terminar):");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero >= 0)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero + " é par.");
                    somaPares += numero;
                }
                else
                {
                    Console.WriteLine(numero + " é ímpar.");
                    somaImpares += numero;
                }

                Console.WriteLine("Digite outro número positivo (ou um número negativo para terminar):");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("A soma dos números pares é " + somaPares + ".");
            Console.WriteLine("A soma dos números ímpares é " + somaImpares + ".");

            Console.ReadKey();

        }
    }
}
