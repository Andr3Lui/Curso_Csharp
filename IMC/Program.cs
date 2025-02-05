﻿namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu peso em kg:");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua altura em metros:");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.Write($"seu peso é {imc:F2}");

            if (imc < 18.5)
            {
                Console.Write("Você está abaixo do peso.");
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                Console.Write("Você está com peso normal");
            }
            else if (imc >= 25 && imc < 29.9)
            {
                Console.Write("Você está sobrepeso.");
            }
            else if (imc >= 30 && imc < 34.9)
            {
                Console.Write("Você está com Obesidade Grau I");
            }
            else if (imc >= 35 && imc < 39.9)
            {
                Console.Write("Você está com Obesidade Grau II");
            }
            else
            {
                Console.Write("Você está com Obesidade Grau III");
            }
        }
    }
}
