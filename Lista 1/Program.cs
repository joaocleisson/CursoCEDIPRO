// See https://aka.ms/new-console-template for more information
Console.WriteLine("<-------------------------Início do Exercício----------------------------->");
Console.WriteLine("<----------------------------Exercício 1---------------------------------->");

// 1.	Faça um Programa que mostre a mensagem "Alo mundo" na tela.

Console.WriteLine("Alô, mundo!");
Console.WriteLine("<----------------------------Exercício 2---------------------------------->");
// 2.	Faça um Programa que peça um número e imprima seu dobro.

// Perguntar o nome ao usuário, ler e armazenar na variável user_insert
Console.Write("Qual o seu nome? ");
string? user_insert = Console.ReadLine();
if(user_insert != null){
    string nome = user_insert;
    // Pedir ao usuário para digitar um número, ler e armazenar na variável num
    Console.Write($"{nome}, digite um número: ");
    double? num = double.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine($"O dobro do número que você digitou é: {num * 2}");
} else {
    Console.Write("É necessário digitar um nome para processir");
    // Perguntar novamente o nome ao usuário, ler e armazenar na variável user_insert
    Console.Write("Qual o seu nome? ");
    string? user_insert2 = Console.ReadLine();
    if(user_insert2 != null){
    string nome = user_insert2;
    // Pedir ao usuário para digitar um número, ler e armazenar na variável num
    Console.Write($"{nome}, digite um número: ");
    double num = double.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine($"O dobro do número que você digitou é: {num * 2}");
    }else{
        Console.Write("você não digitou um número válido, o programa será encerrado.");
        Environment.Exit(0);
    }
}

Console.WriteLine("<----------------------------Exercício 3---------------------------------->");
// 3.	Faça um Programa que converta metros para centímetros. (1 metro tem quantos centímetros? Pense nisso).
// Solicitar ao usuário que insira um valor a ser convertido
Console.WriteLine("Agora você poderá digitar um valor em metros para saber o valor correspondente em centímetros. Vamos lá! ");
Console.Write("Digite o valor em metros: ");
double metros = double.Parse(Console.ReadLine() ?? "0");

// Realizar a conversão
double centimetros = metros * 100;

// Exibir resultado da conversão para o usuário
Console.WriteLine($"{metros} metros equivalem a {centimetros} centímetros.");

Console.WriteLine("<----------------------------Exercício 4---------------------------------->");
// 4.	Escreva um algoritmo para ler as dimensões de um quadrado e mostre sua área (base * altura ou base ).
Console.WriteLine("A seguir, digite o valor da base ou da altura de um quadrado e retornaremos a área dele. ");
Console.Write("Digite um valor:");
double base_altura = double.Parse(Console.ReadLine() ?? "0");
if(base_altura == 0){
    Console.WriteLine("Você digitou um valor nulo, portanto, não foi possível calcular a área do quadrado.");
} else {
    double area_quadrado = base_altura * base_altura;
    Console.WriteLine($"A área do quadrado é {area_quadrado}");
}

Console.WriteLine("<----------------------------Exercício 5---------------------------------->");
// 5.	Faça um Programa que peça o raio de um círculo, calcule e mostre sua área (area do círculo = 3.14 * raio ao quadrado).
Console.WriteLine("A seguir, digite o valor do raio de um círculo e retornaremos a área dele. ");
Console.Write("Digite um valor:");
double raio = double.Parse(Console.ReadLine() ?? "0");
if(raio == 0){
    Console.WriteLine("Você digitou um valor nulo, portanto, não foi possível calcular a área do círculo.");
} else{
    double area_circulo = Math.Pow((raio * 3.14),2);
    Console.WriteLine($"A área do círculo é {area_circulo}");
}

Console.WriteLine("<----------------------------Exercício 6---------------------------------->");
// 6.	Escreva um algoritmo para ler um valor (do teclado) e escrever (na tela) o valor, seu antecessor e seu sucessor (cada um em uma linha).
Console.WriteLine("A seguir, digite um valor e retornaremos ele próprio, seu antecessor e seu sucessor. ");
Console.Write("Digite um valor:");
double? valor_digitado = double.Parse(Console.ReadLine());
if(valor_digitado == null){
    Console.WriteLine("Você não digitou um valor ou inseriu um valor nulo.");
} else{
    Console.WriteLine($"O valor que você digitou é: {valor_digitado}");
    Console.WriteLine($"O antecessor do número digitado é: {--valor_digitado}");
    Console.WriteLine($"O antecessor do número digitado é: {++valor_digitado + 1}");
}

Console.WriteLine("<----------------------------Exercício 7---------------------------------->");
// 7.	Escreva um algoritmo para ler o salário mensal atual de um funcionário e calcular e escrever o valor do novo salário com 12% de reajuste.
Console.WriteLine("Digite o valor do seu salário e lhe daremos 12% de aumento. Olha que maravilha!");
Console.Write("Digite o valor do seu salário: ");
double sal_inicial = double.Parse(Console.ReadLine() ?? "Você não digitou um valor de salário válido, não receberá seu aumento");
if(sal_inicial > 0){
    double sal_atualizado = (sal_inicial * 0.12) + sal_inicial;
    Console.WriteLine($"Aqui está o novo valor do seu salário: {sal_atualizado}");
}

Console.WriteLine("<----------------------------Exercício 8---------------------------------->");
// 8.	Escreva um programa que leia a quantidade de dias, horas, minutos e segundos do usuário. Calcule o total em segundos. (1 minutos tem quantos segundos? 1 hora tem quantos minutos?) 

Console.WriteLine("<----------------------------Exercício 9---------------------------------->");
// 9.	Escreva um algoritmo para ler uma temperatura em graus Fahrenheit, calcular e escrever o valor correspondente em graus Celsius (baseado na fórmula abaixo): 
// Observação: Saiba que 100oC = 212F

Console.WriteLine("<----------------------------Exercício 10--------------------------------->");
// 10.	O custo de um carro novo ao consumidor é a soma do custo de fábrica com a porcentagem do distribuidor e dos impostos (aplicados ao custo de fábrica). Supondo que o percentual do 
//distribuidor seja de 28% e os impostos de 45%, escrever um algoritmo para ler o custo de fábrica de um carro, calcular e escrever o custo final ao consumidor. 
Console.WriteLine("<-----------------------------Fim do Exercício----------------------------------->");
