 Console.BackgroundColor = ConsoleColor.DarkCyan;
Console.WriteLine(@$"

   
                                                                        
");
// Console.ResetColor();







// cor de fundo no console
Console.BackgroundColor = ConsoleColor.Gray;
Console.WriteLine($"Informe o nome do paciente");
// para ler o que o writeline esta escrevendo 
string nome = Console.ReadLine();


Console.WriteLine($"Informe o peso atual do paciente");
// parse serve para converter o texto para numero
float peso =  float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a altura do paciente");
float altura = float.Parse(Console.ReadLine());

float imc = peso / ((float) Math.Pow(altura,2));

Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine(imc);








