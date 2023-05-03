
// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.

const int Senha = 123;

static void Login()
{

    string Usuario = "";


    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(@$"
Bem Vindo ao nosso sistema de produtos 
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



string[] NomeProduto = new string[5];
float[] PrecoProduto = new float[5];
bool[] Promocao = new bool[5];
string PromocaoProdutos = "";


menu:

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(@$"
  ========================
  |      Selecione       |
  ========================
  | CadastrarProduto (1) |
  |   ListarProdutos (2) |
  |        sair      (0) |
  ========================

");

Console.ResetColor();

int menu = int.Parse(Console.ReadLine()!);

switch (menu)
{
    case 1:
        for (var i = 0; i < 5; i++)
        {
            Console.WriteLine($"informe o nome do {i + 1}º produto");
            NomeProduto[i] = Console.ReadLine()!;

            Console.WriteLine($"informe o preço do {i + 1}º produto ");
            PrecoProduto[i] = float.Parse(Console.ReadLine()!);

            Console.WriteLine($"Esse produto esta em promoção?");
            PromocaoProdutos = Console.ReadLine()!;
            
            

            switch (PromocaoProdutos)
            {
                case "Sim":
                    Promocao[i] = true;
                    break;

                case "Nao":
                    Promocao[i] = false;
                    break;
                default:
                   
                    break;
            }
        }

        Console.WriteLine($@"Volte ao menu, por favor: aperte (s)");
        char VoltarMenu = char.Parse(Console.ReadLine()!);
        

         if (VoltarMenu == 's')
                    {
                        goto menu;
                    }
        break;
    case 2:
        for (var i = 0; i < 5; i++)
        {

            // Console.Clear();

            Console.WriteLine($"Nome do {i + 1}º produto: {NomeProduto[i]}");

            Console.WriteLine($"Preço do {i + 1}º produto: {PrecoProduto[i]}");

            Console.WriteLine($"Desconto: {PromocaoProdutos}");
            

        }
        break;

    case 3:
        Environment.Exit(0);
        break;
    default:
        break;
}





