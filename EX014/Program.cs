namespace EX014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = { "Uva", "Maça", "Pera", "Abacate", "Pitaya", "Melancia", "Goiâba", "Manga", "Banana", "Abacaxi" };
            double[] preço = { 2.65, 1.19, 3.14, 2, 4.20, 5, 1.12, 2.17, 4.40, 3.80 };

            for (int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine(frutas[i] + preço[i]);
            }
        }
    }
}
