// // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");


// // declarando uma variavel
// // tipo nime = valor
// String nome = "Mateus";
// const int idade = 16;

// Console.WriteLine("A idade do " +nome+ " é " +idade+ " anos ");

// tipo de dados

// int quantidades = 10;
// double preco = 4.99D;
// float altura = 1.80f;
// bool careca = true;
// string texto = "ola, mundo";
// char letra = 'C';


// operadores de atribuicao

// int idade = 36;

// // operadores aritimedicos

// // soma

// Console.WriteLine(4 + 4);


// // subtracao

// Console.WriteLine(10 - 8);

// multiplicacao

// Console.WriteLine(5 * 10);

// // divisao

// Console.WriteLine(10 / 2);

// // modular

// Console.WriteLine(5 % 2);

// // operadores de comparacao
// Console.WriteLine(5 == 5);


// // igual a

// // maior ou igual a 

// Console.WriteLine(5 >= 4);


// // menor ou igual a 

// Console.WriteLine(4 <= 5);


// // maior que

// Console.WriteLine(5 > 1);


// // menor que

// Console.WriteLine(5 < 7);

// // diferente de 

// Console.WriteLine(5 != 6);


// operadores logicos e tabela verdade 

// && : e

// Console.WriteLine( 5 == 5 && 8 == 8);
// Console.WriteLine( 5 == 5 && 8 == 9);
// Console.WriteLine( 5 == 6 && 8 == 8);
// Console.WriteLine( 5 == 7 && 8 == 9);


// // || : ou

// Console.WriteLine( 5 == 5 || 8 == 8);
// Console.WriteLine( 5 == 5 || 8 == 9);
// Console.WriteLine( 5 == 4 || 8 == 8);
// Console.WriteLine( 5 == 3 || 8 == 9);


// // ! : negação

// Console.WriteLine(!( 5 == 5 || 8 == 8));
// Console.WriteLine(!( 5 == 5 || 8 == 9));
// Console.WriteLine(!( 5 == 4 || 8 == 8));
// Console.WriteLine(!( 5 == 3 || 8 == 9));






// Crie um programa para calacular o imc de uma pessoa

string nome = "Mateus";
float peso = 76.55f;
float altura = 1.80f;


// processamento

float imc = peso / (altura * altura);

Console.WriteLine($" o IMC de " + nome + " é de : " + Math.Round (imc,2));















