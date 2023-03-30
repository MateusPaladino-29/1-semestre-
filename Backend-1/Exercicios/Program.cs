Console.WriteLine($"Informe o Salário");
float Salario = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o Total gasto");
float TotalGasto = float.Parse(Console.ReadLine());

if ( Salario > TotalGasto)

{
    Console.WriteLine($"Gastos dentro do orçamento");
}

else 
{
    Console.WriteLine($"Orçamento estourado");
    
}





