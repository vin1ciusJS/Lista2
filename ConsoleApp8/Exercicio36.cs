using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio36
    {
        public static void Executar()
        {
            Console.WriteLine("este programa irar avaliar os 10 numeors informado e dar o maior o menr e mostrar a media entre os numeros");
            Console.WriteLine();
            Console.WriteLine("informe os numeros de acordo com que forem sendo sinalizados!");
            Console.WriteLine();



            int maior = int.MinValue;
            int menor = int.MaxValue;
            int soma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número inteiro e positivo: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero > maior)
                {
                    maior = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }

                soma += numero;
            }

            double media = soma / 10.0;

            Console.WriteLine("O maior número é " + maior);
            Console.WriteLine("O menor número é " + menor);
            Console.WriteLine("A média dos números é " + media);

        }
    }
}
