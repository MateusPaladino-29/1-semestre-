
static float ImpostoDeRenda(float rendimento)
{

    if (rendimento <= 1500)
    {
        Console.WriteLine($"insento");
        return rendimento * 0;
    }

    else if ( rendimento <= 3500)
    {
        Console.WriteLine($"20% = {rendimento * 0.20f}");
        return rendimento * 0.20f;
    }

    else if ( rendimento<= 6000)
    {
        Console.WriteLine($"25% = {rendimento * 0.25f}");
        return rendimento * 0.25f;

    }

    else
    {
        Console.WriteLine($"35% = {rendimento * 0.35f}");
        return rendimento * 0.35f;
    }
}

Console.WriteLine($"infome seu rendimento de renda");
float rendimento = float.Parse(Console.ReadLine());

float imposto = ImpostoDeRenda(rendimento);


Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"seu rendimento é {rendimento}");
Console.ResetColor();


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"seu imposto é {imposto}");
Console.ResetColor();



Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"seu salario com o imposto é igual a: R$ {rendimento - imposto}");
Console.ResetColor();


