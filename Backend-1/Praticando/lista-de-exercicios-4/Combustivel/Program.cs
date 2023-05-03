float PrecoAlcool = 4.90F;
float PrecoGasolina = 5.30F;

float desconto = 0;


Console.WriteLine(@$"
|-------------------------------------------------
| preço do alcool: 4,90 (1)                       |
|                                                 |
|Preço da GAsolina: 5,30 (2)                      |
|                                                 |
| SELECIONE 1 OU 2 PARA ESCOLHER QUAL VOCE QUER   |
---------------------------------------------------
");


Console.WriteLine($"informe o combustivel que voce quer");
int combustivel = int.Parse(Console.ReadLine());


Console.WriteLine($"informe a quantidade que deseja");
float quantidade = float.Parse(Console.ReadLine());




switch (combustivel) 
{
    case 1:
    if (quantidade <= 20)
    {
       desconto = PrecoAlcool * 0.03f;
        
    }
    else
    {
       desconto = PrecoAlcool * 0.05f;
    }

    Console.WriteLine($"selecionou Alcool");

    Console.WriteLine($"valo total: {(PrecoAlcool-desconto) * quantidade}");
    
    
        break;

        case 2:

        if (quantidade <= 20)
        {
            desconto = PrecoGasolina * 0.04f;
        }
        else
        {
            desconto = PrecoGasolina * 0.06f;
        }

        Console.WriteLine($"Selecionou gasolina");
        
    Console.WriteLine($"valo total: {(PrecoGasolina - desconto) * quantidade} ");

        
        break;

    default:
    Console.WriteLine($"opcao invalida");
    
        break;
}




