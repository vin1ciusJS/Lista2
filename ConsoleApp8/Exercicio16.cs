using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio16
    {
        public static void Executar()
        {
            Console.WriteLine("informe dois numeros e o console ira informar qual e o maior,e menor ou se são iguais");
            Console.WriteLine();

            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (num1 > num2)
            {
                Console.WriteLine("O maior número é " + num1 + " e o menor número é " + num2);
            }
            else if (num1 < num2)
            {
                Console.WriteLine("O maior número é " + num2 + " e o menor número é " + num1);

            }
            else
            {
                Console.WriteLine("Os dois números são iguais.");

                Console.ReadKey();
            }

        }
    }
}
