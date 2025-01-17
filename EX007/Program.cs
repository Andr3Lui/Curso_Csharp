namespace EX007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final, B1, B2, B3, B4;
            string resultado;

            Console.Write("Digite a primeira nota do aluno:");
            B1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a segunda nota do aluno:");
            B2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a terceira nota do aluno:");
            B3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a quarta nota do aluno:");
            B4 = Convert.ToDouble(Console.ReadLine());

            nota_final = (B1 + B2 + B3 + B4) / 4;

            if (nota_final >= 60)
            {
                if (nota_final >= 90)
                {
                    resultado = "Aprovado com louvor!";
                }
                else
                {
                    resultado = "Aprovado";
                }
            }
            else
            {
                if (nota_final >= 40)
                {
                    resultado = "de recuperação";
                }
                else
                {
                    resultado = "Reprovado";
                }
            }

            Console.WriteLine("Notado do Aluno: {0} - O aluno está {1}.",nota_final, resultado);

        }
    }
}
