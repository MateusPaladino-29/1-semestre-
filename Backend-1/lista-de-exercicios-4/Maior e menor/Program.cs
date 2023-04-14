// 4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// menor valor lido.

float[] num = new float[10];

for (var i = 0; i <= 9; i++)
{
    Console.WriteLine($"infome o {i + 1}º ");
    num[i] = float.Parse(Console.ReadLine());
}

Console.WriteLine(@$"
    maior numero: {num.Max()}
    menor numero: {num.Min()}
");

