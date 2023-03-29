Console.WriteLine($"informe o kg");
float Kg = float.Parse(Console.ReadLine());

Console.WriteLine($"informe o valor do produto");
float valor = float.Parse(Console.ReadLine());

float compra = 2 * valor;

Console.WriteLine(@$"
    valor da compra { compra }
");



