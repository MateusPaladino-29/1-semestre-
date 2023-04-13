//DESAFIOS
//Faça um programa que carregue um array de tamanho 6 com números inteiros. Calcule e imprima a quantidade de números ímpares e a quantidade de números pares.  

int[]num = new int[6];

int pares = 0;
int impar = 0;

for (var i = 0; i < 6; i++)
{
    Console.WriteLine($"informe {i + 1} numero");
    num[i] = int.Parse(Console.ReadLine());
    
    if (num[i] % 2 == 0)
    {
        Console.WriteLine($"par");
        pares += 1;
    }

    else
    {
        Console.WriteLine($"impar");
        impar += 1;
    }
}

Console.WriteLine(@$"
Quantidade de números Par: {pares}
Quantidade de números Ímpares: {impar}

");
    

    