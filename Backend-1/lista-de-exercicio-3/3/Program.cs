Console.WriteLine($"informe um numero");
int num = int.Parse(Console.ReadLine());

for (var i = 0; i <= 10 ; i++ )
{
    Console.WriteLine($"{num} x {i} = {num * i}");
    
}
