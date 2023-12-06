using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio41
    {
        public static void Executar()
        {
            Console.WriteLine("Este programa irá classificar a categoria de um nadador baseado na sua idade");
            Console.WriteLine();


            Console.Write("Digite a idade do nadador: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("O nadador pertence à categoria Infantil A.");
            }
            else if (idade >= 8 && idade <= 11)
            {
                Console.WriteLine("O nadador pertence à categoria Infantil B.");
            }
            else if (idade >= 12 && idade <= 13)
            {
                Console.WriteLine("O nadador pertence à categoria Juvenil A.");
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("O nadador pertence à categoria Juvenil B.");
            }
            else if (idade >= 18)
            {
                Console.WriteLine("O nadador pertence à categoria Adultos.");
            }
            else
            {
                Console.WriteLine("Idade fora da faixa etária das categorias.");
            }

        }
    }
}
