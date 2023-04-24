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

Console.WriteLine($"Informe seu Nome:");
novo.Nome = Console.ReadLine()!;

Console.WriteLine($"Informe o nome do seu curso:");
novo.Curso = Console.ReadLine()!;

Console.WriteLine($"Informe sua idade:");
novo.Idade = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o seu RG: ");
novo.RG = Console.ReadLine()!;

Console.WriteLine($"Voce possui bolsa de estudos? true/false");
novo.bolsista = bool.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o valor da sua Media final:");
novo.MediaFinal = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o valor da Mensalidade:");
novo.ValorMensalidade = float.Parse(Console.ReadLine()!);

novo.VerMediaFinal();

novo.VerMensalidade();
















