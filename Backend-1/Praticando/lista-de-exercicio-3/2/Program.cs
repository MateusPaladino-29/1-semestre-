string nome = "";
string senha = "";


while (nome == senha)
{
    Console.WriteLine($"informe o nome do usuario");
     nome = Console.ReadLine();

    Console.WriteLine($"informe a sua senha");
     senha = Console.ReadLine();


    if (senha != nome)
    {
        Console.WriteLine($"obrigado");
        
    }

}

Console.WriteLine($"cadastro concluido");
