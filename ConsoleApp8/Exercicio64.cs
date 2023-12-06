using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio64
    {
        public static void Executar()
        {
            Console.Write("Digite o tamanho do vetor: ");
            int tamanho = Convert.ToInt32(Console.ReadLine());
            vetor = new int[tamanho];

            int opcao;
            do
            {
                Console.WriteLine("1 - Carregar Vetor");
                Console.WriteLine("2 - Listar Vetor");
                Console.WriteLine("3 - Exibir apenas os números pares do vetor");
                Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
                Console.WriteLine("5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor");
                Console.WriteLine("6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor");
                Console.WriteLine("7 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CarregarVetor();
                        break;
                    case 2:
                        ListarVetor();
                        break;
                    case 3:
                        ExibirPares();
                        break;
                    case 4:
                        ExibirImpares();
                        break;
                    case 5:
                        ExibirParesEmPosicoesImpares();
                        break;
                    case 6:
                        ExibirImparesEmPosicoesPares();
                        break;
                }
            } while (opcao != 7);
        }

        static void CarregarVetor()
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite o valor da posição {i}: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void ListarVetor()
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Posição {i}: {vetor[i]}");
            }
        }

        static void ExibirPares()
        {
            Console.WriteLine("Números pares do vetor:");
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        }

        static void ExibirImpares()
        {
            Console.WriteLine("Números ímpares do vetor:");
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        }

        static void ExibirParesEmPosicoesImpares()
        {
            int contador = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (i % 2 != 0 && vetor[i] % 2 == 0)
                {
                    contador++;
                }
            }
            Console.WriteLine($"Quantidade de números pares nas posições ímpares: {contador}");
        }

        static void ExibirImparesEmPosicoesPares()
        {
            int contador = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (i % 2 == 0 && vetor[i] % 2 != 0)
                {
                    contador++;
                }
            }
            Console.WriteLine($"Quantidade de números ímpares nas posições pares: {contador}");

        }
    }
}
