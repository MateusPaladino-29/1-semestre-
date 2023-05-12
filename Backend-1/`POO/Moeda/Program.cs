// Exercício : Faça um programa de conversão de moedas(câmbio) usando classe, membro e métodos estáticos.
// Menu de opções : dólar para real, real para dólar, sair
// Personalizar a resposta, usando recursos da linguagem(Bibliotecas)

using Moeda;


menu:

Console.WriteLine(@$"

 =========================
 |   Real para Dolar (1) |
 |                       |
 |   Dolar Para Real (2) |
 |                       |                
 |      Sair (0)         |
 =========================

");

int menu = int.Parse(Console.ReadLine()!);

switch (menu)
{
    case 1:

        Console.WriteLine($"Informe o valor em reais que voce tem");

        float real = float.Parse(Console.ReadLine()!);

        Console.WriteLine($"Valor da conversão de Reais para Dolares: {Cambio.DolarToReal(real)}");
        goto menu;

        break;

    case 2:

        Console.WriteLine($"Informe o valor em Dolar que vc tem");

        float dolar = float.Parse(Console.ReadLine()!);

        Console.WriteLine($"Valor da conversão de Dolares para Reais: {Cambio.RealToDolar(dolar)}");

        goto menu;

        break;

    case 0:

        Environment.Exit(0);

        break;

    default:
        Console.WriteLine($"Infelizmente voce digitou algo errado, tente novamente");

        goto menu;

        break;
}



// float conversao1 = Cambio.DolarToReal(50);

// Console.WriteLine($"Valor da conversão de Real para Dolar: {conversao1}");

// float conversao2 = Cambio.RealToDolar(50);

// Console.WriteLine($"Valor da conversão de Dolar para Real: {conversao2}");


