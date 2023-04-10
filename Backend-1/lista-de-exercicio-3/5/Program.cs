
int idade = 0;
float peso = 0;
char sexo;
int Totaldemulher = 0;
int Totaldehomem = 0;
int idadeHomem = 0;
double Mediahomem = 0;
int idadeMulher = 0;
double Mediamulher = 0;
int contador = 0;

for (contador = 1; contador <= 3; contador++)
{

    Console.WriteLine(@$"
    informe o seu sexo 

    (m) masculino
    (f) feminino
    
    ");
    sexo = char.Parse(Console.ReadLine()!);

    Console.WriteLine($"informe a sua idade");
    idade = int.Parse(Console.ReadLine()!);

    Console.WriteLine($"informe seu peso");
    peso = float.Parse(Console.ReadLine()!);


    if (sexo == 'm')
    {
        Totaldehomem++;
        idadeHomem = idadeHomem + idade;
    }

    else if (sexo == 'f')
    {

        Totaldemulher++;
        idadeMulher = idadeMulher + idade;
    }

    else
    {
        Console.WriteLine($"esta errado seu idiota");
        
    }
}

Mediahomem = idadeHomem/Totaldehomem;

Mediamulher = idadeMulher/Totaldemulher;

Console.WriteLine(@$"

    A.Total de Homens {Totaldehomem}     
    B.Total de Mulheres: {Totaldemulher}      
    C.Média de idade dos Homens: {Math.Round(Mediahomem,2)}  
    D.Média de idade das mulheres:  {Math.Round(Mediamulher,2)}

");


