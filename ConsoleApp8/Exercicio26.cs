using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio26
    {
        public static void Executar()
        {
            Console.WriteLine("Será gerado os números em ordem decresnte de 100 a 1");
            Console.WriteLine();

            for (int i = 100; i >= 1; i--) // o FOR quer dizer para onde a variavel (i) 
                                           // i >= 1;: Esta é a condição do loop.Enquanto essa condição for verdadeira, o loop continuará a ser executado.
            {
                Console.WriteLine(i);
            }

        }
    }
}
