using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio30
    {
        public static void Executar()
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine();
            Console.WriteLine("Você irá Informar os um número e apos isso escolher qual operação deseja fazer! ");
            Console.WriteLine();
            Console.Write("Digite um número: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escolha a operação (multiplicar (1), dividir (2), subtrair (3), somar (4): ");
            string operacao = Console.ReadLine();

            for (int i = 0; i <= 10; i++) // servira para gerar o luping de 0 a 10 da tabuada de acordo com a operação.
            {
                switch (operacao)
                {
                    case "1":
                        Console.WriteLine(numero + " x " + i + " = " + numero * i);
                        break;
                    case "2":
                        if (i != 0)
                        {
                            Console.WriteLine(numero + " / " + i + " = " + numero / i);
                        }
                        else
                        {
                            Console.WriteLine(numero + " / " + i + " = indefinido");
                        }
                        break;
                    case "3":
                        Console.WriteLine(numero + " - " + i + " = " + (numero - i));
                        break;
                    case "4":
                        Console.WriteLine(numero + " + " + i + " = " + (numero + i));
                        break;
                    default:
                        Console.WriteLine("Operação desconhecida.");
                        break;
                }
                Console.ReadKey();
            }
            }
        }
}
