using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio51
    {
        public static void Executar()
        {
            Console.WriteLine("Este progrma irá mostrar as notas dos alunos e mostrar a média");

            Console.Write("Digite a quantidade de alunos: ");
            int quantidadeAlunos = Convert.ToInt32(Console.ReadLine());

            double somaNotas = 0;
            int alunosAcima7 = 0;
            bool alunoAcima5 = false;

            for (int i = 1; i <= quantidadeAlunos; i++)
            {
                Console.Write($"Digite a nota do aluno {i}: ");
                double nota = Convert.ToDouble(Console.ReadLine());

                somaNotas += nota;

                if (nota > 7)
                {
                    alunosAcima7++;
                }

                if (nota > 5)
                {
                    alunoAcima5 = true;
                }
            }

            double media = somaNotas / quantidadeAlunos;

            Console.WriteLine($"A média aritmética das notas é {media}.");
            Console.WriteLine($"Há {alunosAcima7} alunos com nota acima de 7.0.");

            if (!alunoAcima5)
            {
                Console.WriteLine("Não há nenhum aluno com nota acima de 5.");
            }

        }
    }
}
