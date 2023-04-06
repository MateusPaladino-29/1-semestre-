
// int sim = 0;

// int nao = 0;

// //mulheres q responderam sim 
// int msim = 0;

// int hnao = 0;


// string sexo = "";
// string opn = "";

// for (int i = 1; i <= 10; i++)
// {
//     //  Console.WriteLine($"Digite seu sexo:");
//     //   sexo = Console.ReadLine()!;

//     Console.WriteLine($"Você gostou do produto? responda com sim ou não:");
//      opn = Console.ReadLine()!;


//      if (opn == "sim")
//      {
//         sim ++;        
//      }

//      else
//      {
//         nao ++;
//      }


// }



int pessoasim = 0;
// int pessoasnao = 0;
int mulhersim = 0;
int homemnao = 0;

for (int i = 1; i <= 10; i++)
{

    Console.WriteLine($"digite seu genero: M/F");
    char genero = char.Parse(Console.ReadLine());

    Console.WriteLine($"gostou do produto? S/N");
    char opn = char.Parse(Console.ReadLine());

    switch (opn)
    {
        case 'S':
            pessoasim++;
            if (genero == 'F')
            {
                mulhersim++;
            }
            break;

        case 'N':
            if (genero == 'M')
            {
                homemnao++;
            }
            break;

        default:
            Console.WriteLine($"invalido, tente novamente");
        
            break;
    }

}

Console.WriteLine(@$"
Número de pessoas que responderam Sim: {pessoasim} pessoas
Número de pessoas que responderam Não: {10 - pessoasim} pessoas
Número de mulheres que responderam Sim: {mulhersim} mulheres
Porcentagem de homens que responderam Não: {homemnao}% homens
");


