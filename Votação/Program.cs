namespace Votação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em qual ano você nasceu?");
            int nasc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(voto(nasc));
        }

        static string voto(int ano)
        {
            DateTime DataAtual = DateTime.Now;
            int AnoAtual = DataAtual.Year;
            /*
            int mes = DataAtual.Month;
            int dia = DataAtual.Day;
            int hora = DataAtual.Hour;
            int minutos = DataAtual.Minute;
            int segundo = DataAtual.Second;
            Puxar algum dado relacionado a tempo
            */
            int idade = AnoAtual - ano;
            if (idade < 16)
            {
                return $"Com {idade} anos: você não volta.";
            }
            else if (idade >= 18 && idade < 70)
            {
                return $"Com {idade} anos: você vota!";
            }
            else
            {
                return $"Com {idade} seu voto é opicional.";
            }
        }
    }
}
