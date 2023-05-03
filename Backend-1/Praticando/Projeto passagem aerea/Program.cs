// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

const int Senha = 123;

static void Login()
{

    string Usuario = "";


    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(@$"
Bem Vindo a nossa agencia de turismo 
    --------------------
    |    LOGIN (1)     |
    |                  |
    --------------------

");
    Console.ResetColor();

    Console.ReadLine();

    Console.WriteLine($"Informe o nome do usuario");
    Usuario = Console.ReadLine()!;

SenhaLog:

    Console.WriteLine($"informe a Senha:");
    int SenhaLogin = int.Parse(Console.ReadLine()!);

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

string[] Nome = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];



menu:

Console.WriteLine(@$"

        ===========================
        |                         |
        |   1- Cadastrar passagem |
        |   2- Listar Passagens   | 
        |   0- Sair               |
        |                         |
        ============================


");


Console.WriteLine($"informe qual caminho voce deseja seguir");
int menu = int.Parse(Console.ReadLine()!);

char continuarPrograma = ' ';


switch (menu)
{
    case 1:

    info:
        for (var i = 0; i < 5; i++)
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Digite seu nome:");
            Nome[i] = Console.ReadLine()!;
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Digite sua Origem:");
            origem[i] = Console.ReadLine()!;
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"infotme seu destino:");
            destino[i] = Console.ReadLine()!;
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Informe a data do seu voo: dd/mm/nn");
            data[i] = Console.ReadLine()!;
            Console.ResetColor();
        }


        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Deseja cadastrar uma nova passagem? [s/n]");
        continuarPrograma = char.Parse(Console.ReadLine()!.ToUpper());

        Console.ResetColor();

        if (continuarPrograma == 'S')
        {
            goto info;
        }

        else { goto menu; };


    case 2:
        for (var i = 0; i < 5; i++)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@$"{i + 1}º Seu nome: {Nome[i]}");
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{i + 1}º Sua origem: {origem[i]} ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{i + 1}º Seu destino: {destino[i]} ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{i + 1}º Data do Voo: {data[i]}");
            Console.ResetColor();

        }
        break;


    case 0:

        Environment.Exit(0);

        break;


    default:

    Console.WriteLine($"opção indisponivel!");
    
        break;
}







