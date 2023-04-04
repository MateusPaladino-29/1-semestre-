// Console.WriteLine($"Informe o número correspondente ao dia da semana :");
// int diaSemana = int.Parse(Console.ReadLine());

// switch(diaSemana)
// {
//     case 1 :
//     Console.WriteLine($"Domingo !!!");
//     break;
//     case 2 :
//     Console.WriteLine($"Segunda !!!");
//     break;
//     case 3 :
//     Console.WriteLine($"Terça !!!");
//     break;
//     case 4 :
//     Console.WriteLine($"Quarta !!!");
//     break;
//     case 5 :
//     Console.WriteLine($"Quinta !!!");
//     break;
//     case 6 :
//     Console.WriteLine($"Sexta !!!");
//     break;
//     case 7 :
//     Console.WriteLine($"Sabádo !!!");
//     break;
//     default:
//     Console.WriteLine($"Olha, número informado não é válido amigão !!!!!");
//     break;
    
// Calculadora


// algoritimo
// informar a operação
// informar o primeiro numero
// informar o segundo numero 
// processar os dados
// exibir o resultado

// entrada

// Console.WriteLine(@$"
// -----------------------------
// |   Programa de calculadora |
// |                           |
// |   Informe a operação      |
// |                           |
// |   (+) soma                |
// |   (-) subtração           |
// |   (*) multiplicação       |
// |   (/) divisão             |
// |                           |
// -----------------------------

// ");



// Console.WriteLine($"Informe a opração : (+ , - , * e /)");

// char operacao = char.Parse(Console.ReadLine());
// if (operacao != '+') {
//     Console.WriteLine($"Erro !");
//     return;
// }
// else if (operacao != '-') {
//     Console.WriteLine($"Erro !");
//     return;
// }
// else if (operacao != '*') {
//     Console.WriteLine($"Erro !");
//     return;
// }
// else if (operacao != '/') {
//     Console.WriteLine($"Erro !");
//     return;
// }



// Console.WriteLine($"Informe o primeiro número : ");
// double num1 = double.Parse(Console.ReadLine());

// Console.WriteLine($"Informe o segundo número : ");
// double num2 = double.Parse(Console.ReadLine());

// double resultado = 0;


// // processamento 
// // saída

// switch (operacao)
// {
//     case '+':
//         resultado = (num1 + num2);
//         Console.WriteLine($"O resultado da soma é igual {resultado}");
        
//         break;
//     case '-':
//         resultado = (num1 - num2);
//         Console.WriteLine($"O resultado da subtração é igual {resultado}");
//         break;
//     case '*':
//         resultado = (num1 * num2);
//         Console.WriteLine($"O resultado da multiplicação é igual {resultado}");
//         break;
//     case '/':
//         resultado = (num1 / num2);
//         Console.WriteLine($"O resultado da divisão é igual {resultado}");
//         break;
//     default:
//     Console.WriteLine($"Erro !");
    
//         break;
// }




Console.WriteLine(@$"

-----------------------------
|       Menu do Xandão    |
|                         |
|        Coca cola (1)    |
|        Pepsi     (2)    |
|        Fanta     (3)    |
|        Monster   (4)    |
|                         |
---------------------------

");


Console.WriteLine($"infome o numero da bebida que voce quer: ");
int menu = int.Parse(Console.ReadLine());


string nome = "";




switch (menu)
{
    case 1:
        nome =  "Coca-cola";
          
        break;



    case 2:
       nome = "Pepsi";
          
        break;



    case 3:
        nome = "Fanta";
          
        break;



    case 4:
         nome = "Monster";
          
        break;

    default:
    Console.WriteLine($"informou o valor incorreto, tente novamente");
    
        break;
}

Console.WriteLine($"Gelo adicional?");
string gelo = (Console.ReadLine());

switch (gelo)
{
    case "sim":
    Console.WriteLine($"Gelo adicionado");
        break;

    
    case "nao":
    Console.WriteLine($"Gelo nao adicionado");
        break;

    default:
    Console.WriteLine($"Algo deu errado, tente novamente");
    
        break;
}



Console.WriteLine(@$"
Informe a quantidade que desejar

 --------------------------
|       Menu do Xandão    |
|                         |
|    Copo pequeno (200ml) |
|    Copo medio  (500ml)  |
|    Copo grande (800ml)  |
---------------------------

");
string quantidade = Console.ReadLine();



Console.WriteLine(@$"


    Sua bebida: {nome}

    Adicional de gelo: {gelo}

    O copo desejado é: {quantidade}

");
