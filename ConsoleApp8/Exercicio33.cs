using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio33
    {
        public static void Executar()
        {
            Console.Write("Digite a quantidade de alunos: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            double soma = 0;
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite a matrícula do aluno " + (i + 1) + ": ");
                string matricula = Console.ReadLine();

                Console.Write("Digite a nota do aluno " + matricula + ": ");
                double nota = Convert.ToDouble(Console.ReadLine());

                soma += nota;
            }

            double media = soma / quantidade;
            Console.WriteLine("A média das notas dos alunos é " + media + ".");

            Console.ReadKey();

        }
    }
}
