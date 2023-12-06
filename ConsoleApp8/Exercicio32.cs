using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio32
    {
        public static void Executar()
        {
            Console.WriteLine(" Este programa será capaz de somar o quadros dos proximos numeros informado ente 0 e 10");
            Console.WriteLine();

            Console.Write("Digite um número ímpar menor que 10 e maior que zero: ");
            int numero = Convert.ToInt32(Console.ReadLine());


            if (numero <= 0 || numero >= 10 || numero % 2 == 0)
            {
                Console.WriteLine("Número inválido. Por favor, insira um número ímpar menor que 10 e maior que zero.");
                return;
            }

            int soma = 0;
            for (int i = numero; i < numero + 40; i += 2)
            {
                soma += i * i;
            }

            Console.WriteLine("A soma dos quadrados dos 20 primeiros números inteiros positivos a partir de " + numero + " é " + soma + ".");
            Console.ReadKey();

        }
    }
}
