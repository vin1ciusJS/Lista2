using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio18
    {
        public static void Executar()
        {
            Console.WriteLine("informe um numero de e o console ira dizer se e valido ou não e te mostrarar na tela");
            Console.WriteLine();

            Console.Write("Digite um número inteiro: ");
            Console.WriteLine();
            int codigo = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.WriteLine("UM este é um número Valido!");
                    break;
                case 2:
                    Console.WriteLine("Dois este é um número Valido!");
                    break;
                case 3:
                    Console.WriteLine("TRÊS este é um número Valido!");
                    break;
                default:
                    Console.WriteLine("CÓDIGO INVALIDO");
                    break;


            }
            Console.ReadKey();

        }
    }
}
