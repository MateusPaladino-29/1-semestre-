// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

const int Senha = 123456;

static void Login(){

    string Usuario = "";


Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@$"
Bem Vindo a nossa agencia de turismo 
    --------------------
    |    LOGIN (1)     |
    |    Prescione (1) |
    --------------------

");
Console.ResetColor();

Console.ReadLine();

Console.WriteLine($"Informe o nome do usuario");
Usuario = Console.ReadLine()!;

SenhaLog:

Console.WriteLine($"informe a Senha:");
int SenhaLogin = int.Parse(Console.ReadLine());

if (Senha == SenhaLogin)
{
    Console.WriteLine($"Sua senha esta correta");
    
}
else
{
    Console.WriteLine($"Informe a senha novamente esta incorreta!!");
    
    goto SenhaLog;
}
}

Login();


Console.WriteLine(@$"

        ===========================
        |                         |
        |   1- Cadastrar passagem |
        |   2- Listar Passagens   | 
        |   0- Sair               |
        |                         |
        ============================


");

Console.ReadLine();


string[] Nome = new string[5];




