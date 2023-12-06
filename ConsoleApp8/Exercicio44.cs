using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio44
    {
        public static void Executar()
        {
            string resposta;
            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Conversão de Graus Celsius em Graus Fahrenheit");
                Console.WriteLine("2 - Conversão de Graus Fahrenheit em Graus Celsius");
                Console.WriteLine("3 - Peso ideal do homem");
                Console.WriteLine("4 - Peso ideal da mulher");
                Console.WriteLine("5 - Vetores e Matrizes");
                Console.Write("Opção: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite a temperatura em Celsius: ");
                        double celsius = Convert.ToDouble(Console.ReadLine());
                        double fahrenheit = celsius * 9 / 5 + 32;
                        Console.WriteLine("Temperatura em Fahrenheit: " + fahrenheit);
                        break;
                    case 2:
                        Console.Write("Digite a temperatura em Fahrenheit: ");
                        fahrenheit = Convert.ToDouble(Console.ReadLine());
                        celsius = (fahrenheit - 32) * 5 / 9;
                        Console.WriteLine("Temperatura em Celsius: " + celsius);
                        break;
                    case 3:
                        Console.Write("Digite a sua altura em metros: ");
                        double altura = Convert.ToDouble(Console.ReadLine());
                        double pesoIdealHomem = (72.7 * altura) - 58;
                        Console.WriteLine("Peso ideal para homem: " + pesoIdealHomem + " kg");
                        break;
                    case 4:
                        Console.Write("Digite a sua altura em metros: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        double pesoIdealMulher = (62.1 * altura) - 44.7;
                        Console.WriteLine("Peso ideal para mulher: " + pesoIdealMulher + " kg");
                        break;
                    case 5:
                        Console.WriteLine("Vetores e Matrizes ainda não foram implementados neste programa.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.Write("Deseja encerrar o programa? (S/N): ");
                resposta = Console.ReadLine();
            }
            while (resposta.ToUpper() != "S");

        }
    }
}
