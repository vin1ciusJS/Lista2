using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio04
    {
        public static void Executar()
        {
            Console.WriteLine("informar quatro numeros que devem ser somados e multiplicados entre sí!");
            Console.WriteLine();
            Console.WriteLine("infome o PRIMEIRO número!!");
            Double NA = Double.Parse(Console.ReadLine());
            Console.WriteLine("infome o SEGUNDO número!!");
            Double NB = Double.Parse(Console.ReadLine());
            Console.WriteLine("infome o TERCEIRO número!!");
            Double NC = Double.Parse(Console.ReadLine());
            Console.WriteLine("infome o QUARTO número!!");
            Double ND = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            // as Adiçoes 

            Double somaAB = NA + NB;
            Double somaAC = NA + NC;
            Double somaAD = NA + ND;
            Double somaBC = NB + NC;
            Double somaBD = NB + ND;
            Double somaCD = NC + ND;

            // as multiplicaçoes 

            Double multAB = NA * NB;
            Double multAC = NA * NC;
            Double multAD = NA * ND;
            Double multBC = NB * NC;
            Double multBD = NB * ND;
            Double multCD = NC * ND;

            // MOSTRAR AS SOMAS 

            Console.WriteLine("*********Quanto as SOMAS VEJA ABAIXO*********************");
            Console.WriteLine();

            Console.WriteLine("O resultado da SOMA do PRIMEIRO com o SEGUNDO é: " + somaAB);

            Console.WriteLine("O resultado da SOMA do PRIMEIRO com o TERCEIDO é: " + somaAC);

            Console.WriteLine("O resultado da SOMA do PRIMEIRO com o QUARTO é: " + somaAD);
            Console.WriteLine("O resultado da SOMA do SEGUNDO com o TERCEIRO é: " + somaBC);
            
            Console.WriteLine("O resultado da SOMA do SEGUNDO com o QUARTO é: " + somaBD);
            
            Console.WriteLine("O resultado da SOMA do TERCEIRO com o QUARTO é: " + somaCD);
            Console.WriteLine();

            // MOSTRAR AS MULTIPLICAÇOES 

            Console.WriteLine("*********Quanto as MULTIPLICAÇOES VEJA ABAIXO*************");
            Console.WriteLine();

            Console.WriteLine("O resultado da Multplicação PRIMEIRO com o SEGUNDO é: " + multAB);
            
            Console.WriteLine("O resultado da Multplicação PRIMEIRO com o TERCEIDO é: " + multAC);
            
            Console.WriteLine("O resultado da Multplicação PRIMEIRO com o QUARTO é: " + multAD);
            
            Console.WriteLine("O resultado da Multplicação SEGUNDO com o TERCEIRO é: " + multBC);
            
            Console.WriteLine("O resultado da Multplicação SEGUNDO com o QUARTO é: " + multBD);
            
            Console.WriteLine("O resultado da Multplicação TERCEIRO com o QUARTO é: " + multCD);
            Console.WriteLine();

            Console.ReadKey();

            Console.WriteLine("O resultado da SOMA do SEGUNDO com o TERCEIRO é: " + somaBC);

            Console.WriteLine("O resultado da SOMA do SEGUNDO com o QUARTO é: " + somaBD);

            Console.WriteLine("O resultado da SOMA do TERCEIRO com o QUARTO é: " + somaCD);
            Console.WriteLine();

            // MOSTRAR AS MULTIPLICAÇOES 

            Console.WriteLine("*********Quanto as MULTIPLICAÇOES VEJA ABAIXO*************");
            Console.WriteLine();

            Console.WriteLine("O resultado da Multplicação PRIMEIRO com o SEGUNDO é: " + multAB);

            Console.WriteLine("O resultado da Multplicação PRIMEIRO com o TERCEIDO é: " + multAC);

            Console.WriteLine("O resultado da Multplicação PRIMEIRO com o QUARTO é: " + multAD);

            Console.WriteLine("O resultado da Multplicação SEGUNDO com o TERCEIRO é: " + multBC);

            Console.WriteLine("O resultado da Multplicação SEGUNDO com o QUARTO é: " + multBD);

            Console.WriteLine("O resultado da Multplicação TERCEIRO com o QUARTO é: " + multCD);
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
