namespace EX010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, aumento;

            Console.WriteLine("");
            Console.WriteLine("Digite aqui seu salario:");
            Console.WriteLine("");

            salario = Convert.ToDouble(Console.ReadLine());

            if (salario > 2500)
            {
                aumento = (salario * 0.05);
                Console.WriteLine("Seu aumento é de: {0}", aumento);
                aumento = salario + (salario * 0.05);
                Console.WriteLine("Seu salário final é de: {0}", aumento);
            }
            else if (salario > 1250)
            {
                aumento = (salario * 0.10);
                Console.WriteLine("Seu aumento é de: {0}", aumento);
                aumento = salario + (salario * 0.10);
                Console.WriteLine("Seu salário final é de: {0}", aumento);
            }
            else if(salario <=1250)
            {
                aumento = (salario * 0.15);
                Console.WriteLine("Seu aumento é de: {0}", aumento);
                aumento = salario + (salario * 0.15);
                Console.WriteLine("Seu salário final é de: {0}", aumento);
            }
            
          
            
                
           
        }
    }
}
