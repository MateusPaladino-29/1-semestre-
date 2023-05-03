Console.WriteLine($"informe o nome da pessoa");
string Nome = Console.ReadLine();

Console.WriteLine($"informe a nota 1 :");
float Nota1 = float.Parse(Console.ReadLine());

Console.WriteLine($"informe a nota 2 :");
float Nota2 = float.Parse(Console.ReadLine());

Console.WriteLine($"informe a nota 3 :");
float Nota3 = float.Parse(Console.ReadLine());

Console.WriteLine($"informe a nota 4 :");
float Nota4 = float.Parse(Console.ReadLine());

Console.WriteLine($"informe a nota 5 :");
float Nota5 = float.Parse(Console.ReadLine());

float media = Nota1 + Nota2 + Nota3 + Nota4 + Nota5 / 5;

Console.WriteLine(@$"
    Média do aluno é {media}
");


