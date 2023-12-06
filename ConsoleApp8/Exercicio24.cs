using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio24
    {
        public static void Executar()
        {
            Console.WriteLine("Este programa sera capaz de dizer se os números são!");
            Console.WriteLine("Mlultiplos um do outro, pares e a média entre eles");
            Console.WriteLine();

            int opcao;
            int num1, num2;
            double media;
            char continuar;

            Console.WriteLine("Digite o primeiro número:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            num2 = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Verificar se um dos números é múltiplo do outro");
                Console.WriteLine("2 - Verificar se os dois números são pares");
                Console.WriteLine("3 - Verificar se a média dos dois números é maior ou igual a 7");
                Console.WriteLine("4 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        if (num1 % num2 == 0 || num2 % num1 == 0)
                        {
                            Console.WriteLine("Um dos números é múltiplo do outro.");
                        }
                        else
                        {
                            Console.WriteLine("Nenhum dos números é múltiplo do outro.");
                        }
                        break;
                    case 2:
                        if (num1 % 2 == 0 && num2 % 2 == 0)
                        {
                            Console.WriteLine("Ambos os números são pares.");
                        }
                        else
                        {
                            Console.WriteLine("Ambos os números não são pares.");
                        }
                        break;
                    case 3:
                        media = (num1 + num2) / 2.0;
                        if (media >= 7)
                        {
                            Console.WriteLine("A média dos dois números é maior ou igual a 7.");
                        }
                        else
                        {
                            Console.WriteLine("A média dos dois números é menor que 7.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine("Deseja informar uma nova opção? (S/N)");
                continuar = Convert.ToChar(Console.ReadLine().ToUpper());

            } while (continuar == 'S');

            Console.ReadKey();

        }
    }
}
