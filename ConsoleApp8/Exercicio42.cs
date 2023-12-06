using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio42
    {
        public static void Executar()
        {
            int numero, maior = int.MinValue, menor = int.MaxValue;

            Console.WriteLine("Este progrma irar passar soliciar numeros até que seja digtado ZERO(0) e então irar mostrar o maior e o menor");
            Console.WriteLine();

            do
            {

                Console.Write("Digite um número (0 para sair): ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero != 0)
                {
                    if (numero > maior)
                    {
                        maior = numero;
                    }
                    if (numero < menor)
                    {
                        menor = numero;
                    }
                }
            }
            while (numero != 0);

            Console.WriteLine("O maior número digitado foi: " + maior);
            Console.WriteLine("O menor número digitado foi: " + menor);

            Console.ReadKey();

        }
    }
}
