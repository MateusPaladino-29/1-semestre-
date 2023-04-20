using aprendendo_poo;

Personagem p1 = new Personagem();

Console.WriteLine($"Informe o nome do novo personagem:");
p1.nome = Console.ReadLine()!;


Console.WriteLine($"Informe a idade do novo personagem:");
p1.idade = int.Parse(Console.ReadLine()!);


Console.WriteLine($"Informe a armadura do novo personagem:");
p1.armadura = Console.ReadLine()!;


Console.WriteLine($"Informe a AI do novo personagem:");
p1.ia = Console.ReadLine()!;

Console.WriteLine(@$"

{p1.nome}
{p1.idade}
{p1.armadura}
{p1.ia}

");

p1.Atacar();
p1.Defender();
p1.RestaurarArmadura();



