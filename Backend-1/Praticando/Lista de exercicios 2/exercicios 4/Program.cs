Console.WriteLine($"perguntas");

int incremento = 0;

Console.WriteLine($"Telefonou para a vítima? sim/nao");
string telefone = Console.ReadLine()!.ToUpper();

Console.WriteLine($"Esteve no local do crime? sim/nao");
string local = Console.ReadLine()!.ToUpper();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                

Console.WriteLine($"Mora perto da vitima vítima? sim/nao");
string mora =  Console.ReadLine()!.ToUpper();

Console.WriteLine($"Devia para a vítima? sim/nao");
string devia = Console.ReadLine()!.ToUpper();

Console.WriteLine($"Ja trabalhou com a vítima? sim/nao");
string trabalhou = Console.ReadLine()!.ToUpper();

incremento += (telefone == "SIM") ? 1 : 0;

incremento += (local == "SIM") ? 1 : 0;

incremento += (mora == "SIM") ? 1 : 0;

incremento += (devia == "SIM") ? 1 : 0;

incremento += (trabalhou == "SIM") ? 1 : 0;

if ( incremento == 5)

{
    Console.WriteLine($"CULPADO");
    
}

else if ( incremento >= 5 && incremento <= 3)

{
    Console.WriteLine($"Cumplice");
    
}

else if (incremento == 2)

{
    Console.WriteLine($"Suspeito");  
}


else 
{
    Console.WriteLine($"Inocente");
    
}




