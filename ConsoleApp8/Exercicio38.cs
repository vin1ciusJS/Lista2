using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio38
    {
        public static void Executar()
        {
            char resposta;
            do
            {

                Console.WriteLine("Este programa sera capaz de informar o salario baseado nas horas informadas!");
                Console.WriteLine();

                Console.WriteLine("infome o nome do Funcionario!");
                string nome = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Digite o código do operário: ");
                string codigo = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Digite o número de horas trabalhadas: ");
                int horas = Convert.ToInt32(Console.ReadLine());

                double salario = horas * 10.0;
                double salarioExcedente = 0.0;

                if (horas > 50)
                {
                    int horasExcedentes = horas - 50;
                    salarioExcedente = horasExcedentes * 20.0;
                }

                Console.WriteLine("O salário total do operário " + nome + " codigo " + codigo + " é R$ " + salario + ".");
                Console.WriteLine();
                Console.WriteLine("O salário excedente do operário " + nome + " codigo " + codigo + " é R$ " + salarioExcedente + ".");

                Console.Write("Deseja encerrar o programa (S/N)? ");
                resposta = Convert.ToChar(Console.ReadLine());
            } while (resposta != 'S' && resposta != 's');

        }
    }
}
