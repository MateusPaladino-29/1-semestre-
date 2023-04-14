internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"informe o ano do seu nascimento");
        int AnoDeNascimento = int.Parse(Console.ReadLine());

        int DataAtual = DateTime.Now.Year;

        int anos = DataAtual - AnoDeNascimento;



        if (anos >= 18)
        {
            Console.WriteLine($"Voce é obrigatorio a votar");

        }

        else if (anos >= 60 || anos == 16 || anos == 17)
        {
            Console.WriteLine($"Vote se voce quiser, náo é obrigatorio");

        }

        else
        {
            Console.WriteLine($"voce nao pode votar");

        }
    }
}