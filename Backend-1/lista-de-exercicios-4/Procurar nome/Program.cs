﻿// 6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso



string[] nomes = new string [10];

for (var i = 0; i < 10 ; i++)
{
    
    Console.WriteLine($"Esse é o {i + 1}º nome");
    nomes [i]=  Console.ReadLine()!.ToLower();

}

Console.WriteLine($"Qual nome voce deseja achar?");
string NomeProcurado = Console.ReadLine()!.ToLower();


if (nomes.Contains(NomeProcurado))
{
    Console.WriteLine($"ACHEI");
    
}
else
{
    Console.WriteLine($"nÃO ACHEI");
    
}
