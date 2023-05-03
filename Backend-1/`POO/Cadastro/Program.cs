// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.




using cadastro;

Aluno novo = new Aluno();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Informe seu Nome:");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
novo.Nome = Console.ReadLine()!;
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Informe o nome do seu curso:");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
novo.Curso = Console.ReadLine()!;
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Informe sua idade:");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
novo.Idade = int.Parse(Console.ReadLine()!);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Informe o seu RG: ");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
novo.RG = Console.ReadLine()!;
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Voce possui bolsa de estudos? true/false");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;

string resposta = Console.ReadLine()!.ToLower();
// if (resposta == "Sim")
// {
//     novo.bolsista = true;
// }
// else
// {
//     novo.bolsista = false;
// }

// operador ternario para if else
novo.bolsista = resposta == "Sim" ? true : false;
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Informe o valor da sua Media final:");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
novo.MediaFinal = float.Parse(Console.ReadLine()!);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Informe o valor da Mensalidade:");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
novo.ValorMensalidade = float.Parse(Console.ReadLine()!);
Console.ResetColor();


novo.VerMediaFinal();

novo.VerMensalidade();
















