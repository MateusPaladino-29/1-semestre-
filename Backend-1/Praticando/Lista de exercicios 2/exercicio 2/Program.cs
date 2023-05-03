Console.WriteLine($"informe o primeiro numero");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"informe o segundo numero");
float n2 = float.Parse(Console.ReadLine());

Console.WriteLine($"informe o terceiro numero");
float n3 = float.Parse(Console.ReadLine());

if (n1 > n2 && n2 > n3 && n1 > n3)

{
    Console.WriteLine($" numero maior {n1} e numero menor {n3}");
    
}

else if ( n2 > n1 && n1 > n3 && n2 > n3)

{
    Console.WriteLine($"numero maior {n2} e numero menor {n3}");
    
}

else if (n3 > n1 && n3 > n2 && n2 > n1) 
{
    Console.WriteLine($"numero maior {n3} e o numero menor {n1} ");
    
}

else
{
    Console.WriteLine($"numero maior {n3} e o numero menor {n2}");
    
}
