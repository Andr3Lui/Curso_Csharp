namespace EX013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123"; // Senha correta
            string senhadigitada; // Senha digitada pelo usuário
            int tentativas = 0;  //Contador de tentativas

            // Loop para solicitar a senha ao usuário
            do
            {
                Console.Clear();
                Console.WriteLine("");
                Console.Write("Digite a senha:");
                senhadigitada = Console.ReadLine();
                tentativas++; // Incrementa o contador de tentivas
                
                // Veriifcar se a senha digitada é diferente da senha correta
                if (senhadigitada != senha && tentativas < 3)
                {
                    Console.WriteLine("Senha Incorreta!");
                    Console.WriteLine("");
                    Console.WriteLine("Você ainda tem: " + (3 - tentativas) + " Tentativa(s)");
                    Console.ReadKey();
                }
                else if (senhadigitada != senha && tentativas == 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Senha incorreta! Seu acesso está bloqueado!");
                    return;
                }
            }while (senhadigitada != senha);

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Senha incorreta!");
            Console.WriteLine("");
            Console.Write("Tentativas -" + tentativas);
            Console.WriteLine("");
        }
    }
}
