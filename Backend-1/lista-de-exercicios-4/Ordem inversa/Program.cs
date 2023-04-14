// 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.

float[] num = new float [15];

for (var i = 0; i < 15; i++)
{
    Console.WriteLine($"informe o {i + 1}º numero");
    
    num[i] = float.Parse(Console.ReadLine()!.ToLower()) ;
}

foreach (var item in num.Reverse())
{
    Console.WriteLine($"A ordem inversa dos numeros é: {item}º");
    
}