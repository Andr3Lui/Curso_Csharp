namespace EX008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string resultado;

            Console.Write("Digite um número:");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                resultado = "Par";
            }
            else
            {
                resultado = "Ímpar";
            }

            Console.WriteLine("{0}", resultado);

        }
    }
}
