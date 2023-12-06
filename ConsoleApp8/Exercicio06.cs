using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio06
    {
        public static void Executar()
        {
            Console.WriteLine("converta graus Celsius em Fahreneit");
            Console.WriteLine();
            Console.WriteLine("Informe a temperatura em CELSIUS!!");
            Double C = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Double F = (9 * C + 160) / 5;
            Console.WriteLine();
            Console.WriteLine("A temperatura em CELSIUS de: " + C + "º equivale em Fahreneit e á: " + F);
            Console.ReadKey();        
        }
    }
}
