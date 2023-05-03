// Nesta aula vamos fazer um pequeno sistema de calculadora, em um projeto de console no VsCode.

// Vamos desenvolver um programa orientado a objeto que faça as 4 operações matemáticas.

// Crie uma classe Calculadora;
// Criar um método para cada uma das operações matemáticas(retornar float);
// Fazer o menu de opções;
// Solicitar a entrada de 2 números para o cálculo e exiba o resultado do cálculo no console.


using calculadora;

Calculadora calc = new Calculadora();




Console.WriteLine($"Informe o primeiro numero:");
calc.num1 = float.Parse(Console.ReadLine()!);


Console.WriteLine($"Informe o segundo numero:");
calc.num2 = float.Parse(Console.ReadLine()!);

// menu:

Console.WriteLine(@$"

==========================
|   QUAL OPERAÇÃO DESEJA |
==========================
|       SOMAR (1)        |
|       SUBTRAIR (2)     |
|       MULTIPLICAR(3)   |
|       DIVIDIR (4)      |
|       SAIR (0)         |
==========================

");

Console.WriteLine($"Selecione qual operação matematica, voce deseja");
float operacao = float.Parse(Console.ReadLine()!);


switch (operacao)
{
    case 1:
        Console.WriteLine($"Resultado da soma: {calc.somar()}");

        break;

    case 2:
        Console.WriteLine($"Resultado da subtração: {calc.subtrair()}");

        break;

    case 3:
        Console.WriteLine($"Resultado da multiplicação: {calc.multiplicar()}");
        
        break;

    case 4:
        Console.WriteLine($"Resultado da divisão: {calc.dividir()}");
        
        break;

    case 0:
        Environment.Exit(0);
        break;
    
    default:

        Console.WriteLine($"Selecionou a opção errada");
        break;
}








// Console.WriteLine($"Deseja saber o resultado das demais  operações? Sim/Nao");
// string demais = (Console.ReadLine()!.ToLower());


// if (demais == "Sim")
// {
//     Console.WriteLine(@$"

//  soma: {calc.somar()}
//  subtração: {calc.subtrair()}
//  multiplicação: {calc.multiplicar()}
//  divisão: {calc.dividir()}

// ");
// }


// else
// {
//     Console.WriteLine($"Volte ao menu");
//     goto menu;
// }





