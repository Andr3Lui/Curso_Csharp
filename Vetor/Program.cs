using System;
using System.Globalization;

namespace Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            int[] num = new int[5];

            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            num[3] = 40;
            num[4] = 50;
            //num[5] = 60; Erro, passou dos limites do vetor, vetor vai apenas até a 4 posições.
            Console.WriteLine(num[3]);

            int[] n = new int[5] { 60, 70, 80, 90, 100 };
            Console.WriteLine(n[3]);

            int[] numero = { 67, 87, 90, 43, 12, 8, 4, 8, 78 };
            Console.WriteLine(numero[6]);
            

            Random random = new Random();
            int[] vetor = new int[10];

            for (int i = 0; i < 10; i++)
            {
                vetor[i] = random.Next(1, 100);
                Console.WriteLine(vetor[i]);
            }

            Console.WriteLine();
            double[] reais = new double[10];

            for (int i = 0; i < 10; i++)
            {
                reais[i] = random.NextDouble() * 10000;
                Console.WriteLine(reais[i].ToString("C2"));
            }
            */

            string[] nomes = { "Maria", "João", "Carlos", "Ana", "Pedro", "José", "Neymar", "Vini JR" };

            for (int i = 0; i < nomes.Length; i++)
            {
                if(i < nomes.Length - 1)
                {
                    Console.Write(nomes[i] + ", ");
                }
                else
                {
                    Console.WriteLine(nomes[i] + ".");
                }
                
            }

        }   
    }
}
