using System;

namespace EX011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================");
            Console.WriteLine("Emprestimo Bancário");
            Console.WriteLine("===================");
            double casa, salario;
            int anos;

            Console.WriteLine("Digite o valor da casa desejada:");
            casa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite seu salário:");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite em quantos deseja pagar:");
            anos = Convert.ToInt32(Console.ReadLine());
            
           
            
        }
    }
}
