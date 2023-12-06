using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio55
    {
        public static void Executar()
        {
            Console.Write("Digite uma frase (até 50 caracteres): ");
            string frase = Console.ReadLine();

            if (frase.Length > 50)
            {
                Console.WriteLine("A frase é muito longa. Por favor, digite uma frase com até 50 caracteres.");
                return;
            }

            string fraseSemEspacos = frase.Replace(" ", "");
            int quantidadeEspacos = frase.Length - fraseSemEspacos.Length;

            Console.WriteLine($"Frase sem espaços: {fraseSemEspacos}");
            Console.WriteLine($"Quantidade de espaços: {quantidadeEspacos}");

            Console.ReadKey();


        }
    }
}
