Console.WriteLine("Olá! Vamos construir um sistema que vai calcular a média dos alunos!");

Console.WriteLine($"Entre com a nota da primeira sprint: ");
float nota1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Entre com a nota da segunda sprint: ");
float nota2 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Entre com a nota da terceira sprint: ");
float nota3 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Entre com a nota da quarta sprint: ");
float nota4 = float.Parse(Console.ReadLine()!);

float media = (nota1+nota2+nota3+nota4)/4;

Console.WriteLine($"A média de nota do aluno é: " + media);
