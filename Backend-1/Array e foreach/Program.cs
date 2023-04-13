


// int[]numeros = new int[5];

// for (int i = 0; i <5; i++)
// {
//     Console.WriteLine($"informe o {i +1}º número : ");
//     numeros[i] = int.Parse(Console.ReadLine()!);
    
// }

// foreach (int item in numeros)
// {
//     Console.WriteLine($"exibicao da ordem dos numeros informados: {item} e o dobro dele é: {item * 2}");
    
// }


// \r\n;

// string[]nome = new string[5];

// int[] idade = new int[5];

// for (var i = 0; i <2; i++)
// {
//     Console.WriteLine($"informe {i + 1}º nome:");
//     nome[i] = Console.ReadLine()!;

//     Console.WriteLine($" informe a {i +1}º idade:");
//     idade[i] = int.Parse(Console.ReadLine()!);
// }

// for (var i = 0; i <2; i++)
// {
//     Console.ForegroundColor = ConsoleColor.DarkBlue;
//     Console.WriteLine($"{i + 1}) Nome: {nome[i]}");
//     Console.ResetColor();
    
//     Console.ForegroundColor = ConsoleColor.Green;
//     Console.WriteLine(@$"Idade: {idade[i]} anos
//     ");

// }




//DESAFIOS
//Faça um programa que carregue um array de tamanho 6 com números inteiros. Calcule e imprima a quantidade de números ímpares e a quantidade de números pares.  

int[]num = new int[6];

for (var i = 0; i < 6; i++)
{
    Console.WriteLine($"informe {i + 1} numero");
    int numero = int.Parse(Console.ReadLine());
    
    if (num[i] % 2 == 0)
    {
        Console.WriteLine($"par");
        
    }

    else
    {
        Console.WriteLine($"impar");
        
    }
    
}








