using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio12
    {
        public static void Executar()
        {
            Console.WriteLine("encontar o modulo de um numero!");
            Console.Write("Digite um número inteiro: ");

            int numero = int.Parse(Console.ReadLine()); //no lugar de int.Parse poderia usar tambem Convert.ToInt32 isso converte para numeros
            // e caso seja usado texto(string) pelo usurario ele converte ou retorna 0

            int modulo = numero >= 0 ? numero : numero * -1; // a parte numero * -1 isso ira fazer com que o numero se torne prosivivo

            Console.WriteLine("O módulo do número é: " + modulo);
            Console.ReadKey();
        }
    }
}
