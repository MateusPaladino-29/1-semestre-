Console.WriteLine($"Informe a quantidade de Gols do Corinthians");
int time1 = int.Parse(Console.ReadLine());

Console.WriteLine($"informe a quantidade de Gols do Palmeiras");
int time2 = int.Parse(Console.ReadLine());

if (time1 > time2)

{
    Console.WriteLine($"Corinthians ganhou de {time1} x {time2}");
    
}

else if ( time2 > time1 )
{
    Console.WriteLine($"Palmeiras ganhou de {time2} x {time1}");
    
}

else 
{
    Console.WriteLine($"o jogo deu Empate");
    
}

