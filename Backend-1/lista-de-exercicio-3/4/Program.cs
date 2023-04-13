

int pessoasim = 0;
// int pessoasnao = 0;
int mulhersim = 0;
int homemnao = 0;

for (int i = 1; i <=10 ; i++)
{

    Console.WriteLine($"digite seu genero: M/F");
    char genero = char.Parse(Console.ReadLine().ToUpper());

    Console.WriteLine($"gostou do produto? S/N");
    char opn = char.Parse(Console.ReadLine().ToUpper());

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
Porcentagem de homens que responderam Não: {homemnao} homens
");




