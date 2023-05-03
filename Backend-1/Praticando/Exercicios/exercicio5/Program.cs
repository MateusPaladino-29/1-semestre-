Console.WriteLine("informe a quantidade de maca comprada");
int maca = int.Parse(Console.ReadLine());

float valor = maca * (float)(maca >= 12 ? 0.30 : 0.25);

Console.WriteLine($"valor da compra é {valor}");



