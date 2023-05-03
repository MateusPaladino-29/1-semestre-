Console.WriteLine($"Informe o lado 1");
float Lado1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o lado 2");
float Lado2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o lado 3");
float Lado3 = float.Parse(Console.ReadLine());

if(Lado1 == Lado2 && Lado2 == Lado3)

{
    Console.WriteLine($"Triângulo Equilátero");
}

else if (Lado1 == Lado2 || Lado1 == Lado3 || Lado2 == Lado3)

{
    Console.WriteLine($" Triângulo Isóscele");
    
}

else
{
    Console.WriteLine($"Triângulo Escaleno");
    
}

