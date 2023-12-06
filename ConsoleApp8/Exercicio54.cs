using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Exercicio54
    {
        public static void Executar()
        {
            Console.WriteLine("Este prgrama faz a comparação emtre os dois grupos e vetores e analisa os comuns entre si ");
            Console.WriteLine();

            int[] A = new int[5];
            int[] B = new int[8];

            Console.WriteLine("Digite os elementos do vetor A:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Digite os elementos do vetor B:");
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                B[i] = Convert.ToInt32(Console.ReadLine());
            }

            List<int> comuns = new List<int>();

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j] && !comuns.Contains(A[i]))
                    {
                        comuns.Add(A[i]);
                    }
                }
            }

            Console.WriteLine("Elementos comuns aos dois vetores:");
            foreach (int num in comuns)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();


        }
    }
}
