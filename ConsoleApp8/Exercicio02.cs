using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio02
    {
        public static void Executar()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear(); // Necessário para aplicar a cor de fundo ao console inteiro (apenas uma perfumaria
            // para a tela ficar na cor azul 

            Console.WriteLine("Faça um cotação entre o Dollar e o Real e passe Raiva por ser brasileiro!!");
            Console.WriteLine();
            Console.WriteLine("informe o valor do Dollar na cotação de hoje");
            double Dollar = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a QUANTIDADE de Dollar que deseja trocar por Real brasileiro!");
            double QTA = double.Parse(Console.ReadLine());
            Console.WriteLine();
            double Cotacao = QTA * Dollar;
            Console.WriteLine("esta quantidade de Dollar equivale em reais o valor de R$: " + Cotacao.ToString("#0.00"));
            //  .ToString("#0.00") vai servir para mostar penas as casas decimais após a virgula no caso aqui duas
            // ele está convertendo o decimal em uma string #0.00” significa que você quer que o número tenha pelo
            // menos um dígito antes da vírgula e exatamente dois dígitos depois da vírgula
            Console.ReadKey();

        }
    }
}
