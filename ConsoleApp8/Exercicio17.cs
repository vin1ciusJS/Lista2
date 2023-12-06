using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio17
    {
        public static void Executar()
        {
            Console.WriteLine("este programa sera capaz de identicar se um numero e valido ou invalido");
            Console.WriteLine();
            Console.Write("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0 && num <= 9) //  o simbolo && E comercial se refer a vogal E neste caso seria
                                      //  "se numero for maior que 0 e menor 9 e valido."

            {
                Console.WriteLine("Valor válido");
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
            
        }
    }
}
