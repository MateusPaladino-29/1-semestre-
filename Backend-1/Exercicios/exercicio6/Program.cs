Console.WriteLine($"informe a sua frequencia em aulas");
float frequencia = float.Parse(Console.ReadLine());


Console.WriteLine($"Informe sua nota");
float nota1 = float.Parse(Console.ReadLine());



if ( frequencia >= 75 && nota1 >= 7.0 )

{
    Console.WriteLine($"Passou direto");
}


else if ( frequencia >= 75 && nota1 < 7 && nota1 > 3)

{
    Console.WriteLine($"Voce tem direito a recuperacao");
    
}

else 

{
    Console.WriteLine($"Reprovou");
    
}

