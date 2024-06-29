// See https://aka.ms/new-console-template for more information

// 1.	Faça um Programa que mostre a mensagem "Alo mundo" na tela.

Console.WriteLine("Alô, mundo!");

// 2.	Faça um Programa que peça um número e imprima seu dobro.

// Perguntar o nome ao usuário, ler e armazenar na variável nome
Console.Write("Qual o seu nome? ");
string nome = Console.ReadLine();
// Pedir ao usuário para digitar um número, ler e armazenar na variável num
Console.Write($"{nome}, digite um número: ");
double num = double.Parse(Console.ReadLine());
Console.WriteLine($"O dobro do número que você digitou é: {num * 2}");

// 3.	Faça um Programa que converta metros para centímetros. (1 metro tem quantos centímetros? Pense nisso).
// Solicitar ao usuário que insira um valor a ser convertido
Console.Write("Digite o valor em metros: ");
double metros = double.Parse(Console.ReadLine());

// Realizar a conversão
double centimetros = metros * 100;

// Exibir resultado da conversão para o usuário
Console.WriteLine($"{metros} metros equivalem a {centimetros} centímetros.");
