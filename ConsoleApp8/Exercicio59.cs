using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio59
    {
        public static void Executar()
        {
            Console.WriteLine("Este programa pede duas letras em A e Z e te fala quantos caracteres existem entre eles");
            Console.WriteLine();

            Console.Write("Digite o primeiro caractere (A-Z): ");
            char primeiroCaractere = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

            Console.Write("Digite o segundo caractere (A-Z): ");
            char segundoCaractere = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

            if (primeiroCaractere < 'A' || primeiroCaractere > 'Z' || segundoCaractere < 'A' || segundoCaractere > 'Z')
            {
                Console.WriteLine("Erro: ambos os caracteres devem estar entre A e Z.");
                return;
            }

            if (primeiroCaractere >= segundoCaractere)
            {
                Console.WriteLine("Erro: o primeiro caractere deve ser alfabeticamente anterior ao segundo caractere.");
                return;
            }

            int numeroCaracteres = segundoCaractere - primeiroCaractere - 1;

            Console.WriteLine($"O número de caracteres entre {primeiroCaractere} e {segundoCaractere} é: {numeroCaracteres}");
            Console.ReadKey();

        }
    }
}
