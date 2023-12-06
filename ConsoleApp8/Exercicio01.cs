using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Exercicio01
    {
        public static void Executar()
        {
            Console.WriteLine("CALCULO MÉDIA DE ESTOQUE MINIMO E MAXIMO");
            Console.WriteLine("insira o NOME do produto");
            string Nome = Console.ReadLine();
            Console.WriteLine("insira o estoque minimo do produto");
            int minimo = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o estoque MAXIMO do produto");
            int maximo = int.Parse(Console.ReadLine());

            int media = minimo + maximo / 2;

            Console.WriteLine("a media do produto " + Nome + "é:" + media);

            Console.ReadKey();
        }
    }
}
