using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio14
    {
        public static void Executar()
        {
            Console.WriteLine("informe dois numeros e o console ira mostrar a diferença entre eles!");
            Console.WriteLine();
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int diferenca;

            if (num1 > num2)
            {
                diferenca = num1 - num2;
                Console.WriteLine($"A diferença entre {num1} e {num2} é: {diferenca}");
            }
            else if (num2 > num1)
            {
                diferenca = num2 - num1;
                Console.WriteLine($"A diferença entre {num2} e {num1} é: {diferenca}");
            }
            else
            {
                Console.WriteLine("Os números são iguais, portanto, a diferença é 0.");

                Console.ReadKey();
            }
        }
    }
}
