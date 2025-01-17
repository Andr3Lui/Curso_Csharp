namespace EX007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final = 29;
            string resultado;

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
