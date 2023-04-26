// Faça em sua máquina utilizando os mesmos conceitos dado em aula.
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.


using celular;

cells cell = new cells();

// inicio:

Console.WriteLine($"Qual a cor do celular?");
cell.cor = Console.ReadLine()!;

Console.WriteLine($"Qual o modelo do celular?");
cell.modelo = Console.ReadLine()!;

Console.WriteLine($"Qual o tamanho do celular?");
cell.tamanho = Console.ReadLine()!;


inicio:

Console.WriteLine($"O celular esta ligado?");
string resposta = Console.ReadLine()!.ToUpper();

// cell.Ligado = resposta == "Sim" ? true : false;


if (resposta == "SIM")
{
    cell.Ligado = true;
    
}
else
{
    cell.Ligado = false;
    goto inicio;
}



Menu:

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(@$"
   
==============================
|     Menu do seu celular    |
| =========================  |
|  Fazer uma ligação (1)     |
|                            |
|   Mandar uma mensagem (2)  |
|                            |
|   Deseja desligar? (0)     |
==============================
");

Console.ResetColor();

Console.WriteLine($"O que deseja ultilizar?");
string opcao = Console.ReadLine()!;

switch (opcao)
{
    case "1":

    cell.Ligar();
    goto Menu;
        break;

    case "2":

    cell.MandarMensagem();

    goto Menu;
    
    break;

    case "0":

    cell.Desligar();

    Environment.Exit(0);
    
    break;

    default:    
        break;
}






