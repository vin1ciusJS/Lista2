using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio15
    {
        public static void Executar()
        {
            Console.WriteLine("Este progrma ira calcular as notas do aluno e mostrar se ele esta aprovado ou reprovado!");
            Console.WriteLine();
            Console.WriteLine("informe o nome do Aluno!");
            string Nome = Console.ReadLine();

            Console.WriteLine("infome as notas (0 a 100) do aluno ");
            Console.WriteLine();

            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            double nota4 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 70)
            {
                Console.WriteLine("O" + Nome + "foi aprovado com uma média de " + media);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("o Aluno está de recuperação");
                Console.WriteLine();
                Console.Write("Digite a nota da recuperação: ");
                double notaRecuperacao = double.Parse(Console.ReadLine());
                Console.WriteLine();

                media = (media + notaRecuperacao) / 2;

                if (media >= 70)
                {
                    Console.WriteLine("O" + Nome + "foi aprovado com uma média de " + media);
                }
                else
                {
                    Console.WriteLine("O" + Nome + "esta REPROVADO com uma média de " + media);

                    Console.ReadKey();

                }
            }
        }
    }
}
