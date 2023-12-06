using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio09
    {
        public static void Executar()
        {
            Console.WriteLine("informe sua dada de aniversaio e saiba quantos dias você ja  viveu!");
            Console.WriteLine();
            Console.WriteLine("informe o ANO do seu nascimento!");
            int AN = int.Parse(Console.ReadLine());

            Double Anos = 2023 - AN;
            Double Meses = Anos * 12;
            double Dias = Meses * 30;

            Console.WriteLine("se você nasceu em: " + AN + " você já está com : " + Anos + " anos e " + Meses + " e " + Dias + " Dias");

            Console.ReadKey();

        }
    }
}
