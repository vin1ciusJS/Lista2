using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio39
    {
        public static void Executar()
        {
            string resposta;
            do
            {

                Console.WriteLine("Este programa sera capz de ler o númro inteiro e dizer ´se este e negativou ou positivo e se par ou impar!");
                Console.WriteLine();

                Console.Write("Digite um número inteiro: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0) //para saber se o numero e par ou impar    
                {
                    Console.WriteLine("O número é par.");
                }
                else
                {
                    Console.WriteLine("O número é ímpar.");
                }

                if (numero >= 0) // saber se é negativo
                {
                    Console.WriteLine("O número é positivo.");
                }
                else
                {
                    Console.WriteLine("O número é negativo.");
                }

                Console.Write("Deseja encerrar o programa? (S/N): ");
                resposta = Console.ReadLine();
            }
            while (resposta.ToUpper() != "S");

        }
    }
}
