using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio03
    {
        public static void Executar()
        {
            Console.WriteLine("Calculo de comissão de vendedor sob vendas de produtos");
            Console.WriteLine();
            Console.WriteLine("infome o NOME do Vendedor(a)");
            string Nome = (Console.ReadLine());
            Console.WriteLine("informe o ID do vendedor(a)");
            int Id = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("infomer o nome do PRODUTO que está sendo Vendido!");
            string Produto = (Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("informe o VALOR do " + Produto + " que o cliente esta levando!");
            double Valor = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("informe a QUANTIDADE de " + Produto + " que o clinte esta levando!");
            int QTA = int.Parse(Console.ReadLine());
            Console.WriteLine();
            double ValorT = Valor * QTA;
            Double Comissao = ValorT * 0.05;
            Console.WriteLine(" O Valor toral dos produtos vendidos é  R$ :" + ValorT);
            Console.WriteLine(" O vendedor(a)  " + Nome + " ID " + Id + " recebera de comissão pela venda do  " + Produto + " é de R$ " + Comissao);

            Console.ReadLine();

        }
    }
}
