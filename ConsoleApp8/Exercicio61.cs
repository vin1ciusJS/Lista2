using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio61
    {
        public static void Executar()
        {
            Console.WriteLine("este programa faz um calculo de reajuste de salario ");

            Console.Write("Digite o valor do salário: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o índice de reajuste (em porcentagem): ");
            double indiceReajuste = Convert.ToDouble(Console.ReadLine());

            double salarioAtualizado = Reajuste(salario, indiceReajuste);

            Console.WriteLine($"O salário atualizado é {salarioAtualizado}.");
        }

        static double Reajuste(double salario, double indiceReajuste)
        {
            return salario * (1 + indiceReajuste / 100);
        }

    }
}