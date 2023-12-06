using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio23
    {
        public static void Executar()
        {
            Console.WriteLine("calculadora escola a operação e informe os números desejados");
            Console.WriteLine();

            int opcao;
            double num1, num2, resultado;

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine();
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            opcao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            num2 = Convert.ToDouble(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("Resultado: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;



            }

            Console.ReadKey();

        }
    }
}
