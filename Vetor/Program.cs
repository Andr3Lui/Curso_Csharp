namespace Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
