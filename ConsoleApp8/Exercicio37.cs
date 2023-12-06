using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio37
    {
        public static void Executar()
        {
            char resposta;
            do
            {
                Console.WriteLine("este programa sera capaz de ver fazeer calculos materimaticos simples");
                Console.WriteLine();
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.Write("Informe a opção: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o primeiro número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Resultado: " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Resultado: " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Resultado: " + (num1 * num2));
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            Console.WriteLine("Resultado: " + (num1 / num2));
                        }
                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção desconhecida.");
                        break;
                }

                Console.Write("Deseja voltar ao menu principal (S/N)? ");
                resposta = Convert.ToChar(Console.ReadLine());
            } while (resposta == 'S' || resposta == 's');

        }
    }
}
