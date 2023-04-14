
float desconto = 0;

Console.WriteLine($"informe o produto que voce deseja");
string NomeProduto = Console.ReadLine();

Console.WriteLine($"infome a quantidade que deseja");
int Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o preco unitario do produto");
float PrecoUnitario = float.Parse(Console.ReadLine());


if (Quantidade <= 5)
{
    desconto = PrecoUnitario * 0.02f;
}

else if (Quantidade >= 5 && Quantidade <= 10)
{

    desconto = PrecoUnitario * 0.03f;
}

else
{

    desconto = PrecoUnitario * 0.05f;

}

Console.WriteLine(@$"

valor total: {(PrecoUnitario - desconto) * Quantidade}

");