using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio07
    {
        public static void Executar()
        {
            Console.WriteLine("converta graus Fahreneit em Celsius");
            Console.WriteLine();
            Console.WriteLine("Informe a temperatura em Fahreneit!!");
            Double F = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Double C = (F - 32) * 5 / 9;
            Console.WriteLine("A temperatura em Fahreneit de: " + F + " equivale em Celsius e á: " + C.ToString("#0.00º"));
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
