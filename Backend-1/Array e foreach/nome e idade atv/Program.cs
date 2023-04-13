string[]nome = new string[5];

int[] idade = new int[5];

for (var i = 0; i <2; i++)
{
    Console.WriteLine($"informe {i + 1}º nome:");
    nome[i] = Console.ReadLine()!;

    Console.WriteLine($" informe a {i +1}º idade:");
    idade[i] = int.Parse(Console.ReadLine()!);
}

for (var i = 0; i <2; i++)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($"{i + 1}) Nome: {nome[i]}");
    Console.ResetColor();
    
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@$"Idade: {idade[i]} anos
    ");

}



