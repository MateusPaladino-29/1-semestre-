// int x = 1;

// while (x <= 10)
// {
//     Console.WriteLine(x);
//     x++;    
// }


// bool idadeCerta = false;

// while (idadeCerta == false) //while
// {
//     Console.WriteLine($"Qual a idade do Adulto Ney ? ");
//     int idade = int.Parse(Console.ReadLine());

//     if (idade == 31)
//     {
//         idadeCerta = true;
//     }
    
    
// }




// bool idadeCerta = false;

// do
// {

// Console.WriteLine($"Qual a idade do Adulto Ney ?");
// int idade =int.Parse(Console.ReadLine());

// if (idade == 31)
// {
//     Console.WriteLine($"Acertou !!S");
//     idadeCerta = true;
    
// }
// else
// {
//     Console.WriteLine($"Errou feio ! Tente novamente ");
    
// }
    


// } while (idadeCerta == false);

bool Cadastro1 = true;

bool Cadastro2 = true;

bool Cadastro3 = true;

bool Cadastro4 = true;

string vazio = "";
string nome = "";

do
{
    Console.WriteLine($"Coloque seu nome");
    nome = Console.ReadLine();
    
    if (vazio != nome ) 
    {
        Console.WriteLine($"Certo proximo passo");
        Cadastro1 = true;
    }

    else
    {
        Console.WriteLine($"informe seu nome novamente");
        
    }
    
} while (nome == vazio);



int idade = 0;
do
{
    Console.WriteLine($"informe a sua idade");
      idade = int.Parse(Console.ReadLine());

    if(idade <=100 && idade >=0)
    {
        Console.WriteLine($"certo, proximo passo");
        Cadastro2 = true;
        
    }
    
    else
    {
        Console.WriteLine($"tente novamente ou sua idade ultrapassou a 100 anos");
        
    }

} while (idade >100 || idade <= 0);



float salario = 0;

do
{
    Console.WriteLine($"Informe seu salario");
     salario = float.Parse(Console.ReadLine());
    

    if (salario > 0)
    {
        Console.WriteLine($"Certo, proximo passo");
       
    }

    else
    {
        Console.WriteLine($"Tente novamente");
        
    }

} while (salario < 0);


char estado = 'a';

do
{
    Console.WriteLine($"Qual seu estado civil? informe apenas com a primeira letra");
     estado = char.Parse(Console.ReadLine().ToLower());

if (estado == 's' || estado == 'c' || estado == 'v' || estado == 'd')
{
    Console.WriteLine($"ok, aguarde");
   
    

}

else
{
    Console.WriteLine($"Tente novamente");
    
}


} while (estado != 's' && estado != 'c' && estado != 'v' && estado != 'd');



Console.WriteLine($"parabens, cadastro concluido");

