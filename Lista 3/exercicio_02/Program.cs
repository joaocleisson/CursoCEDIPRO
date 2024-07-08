// See https://aka.ms/new-console-template for more information

// 2. Faça um Programa que leia 2 números e em seguida pergunte ao usuário qual operação ele deseja realizar 
//    (Adição, Subtração, Soma ou Divisão). O resultado da operação deve ser acompanhado de uma frase que mostre 
//    o resultado e se ele  é:
//	    par ou ímpar;
//	    positivo ou negativo;
//	    inteiro ou decimal.

using System.Globalization;

// Declaração de variáveis necessárias para a execução do programa
double resultado = 0;
string par_impar, positivo_negativo, inteiro_decimal;

// Usuário digita o primeiro número, esse é resgatado e convertido para double. Tratamento para possíveis nulos
Console.Write("Digite um número: ");
string? num1_dig = Console.ReadLine();
if (!double.TryParse(num1_dig, NumberStyles.Any, CultureInfo.InvariantCulture, out double num1)){
    Console.WriteLine("Você não digitou um número válido. O programa será encerrado.");
    Environment.Exit(0);
}

// Usuário digita o segundo número, esse é resgatado e convertido para double. Tratamento para possíveis nulos
Console.Write("Digite outro número: ");
string? num2_dig = Console.ReadLine();
if (!double.TryParse(num2_dig, NumberStyles.Any, CultureInfo.InvariantCulture, out double num2)){
    Console.WriteLine("Você não digitou um número válido. O programa será encerrado.");
    Environment.Exit(0);
}

// Usuário digita o número correspondente à operação que deseja realizar.
// O número digitado é resgatado e convertido para double. Tratamento para possíveis nulos
Console.WriteLine("Qual operação você deseja realizar?");
Console.Write("Digite: 1 para Adição, 2 para Subtração, 3 para Multiplicação e 4 para Divisão: \n");
string? operacao_dig = Console.ReadLine();
if (!double.TryParse(operacao_dig, NumberStyles.Any, CultureInfo.InvariantCulture, out double operacao)){
    Console.WriteLine("Você não digitou um número de operação válido. O programa será encerrado.");
    Environment.Exit(0);
}

// Validar qual a operação escolhida
if(operacao == 1){
    resultado = num1 + num2;
} else if (operacao == 2){
    resultado = num1 - num2;
} else if (operacao == 3){
    resultado = num1 * num2;
} else {
    resultado = num1 / num2;
}

// Validar se o número é par ou ímpar
if (resultado % 2 == 0){
    par_impar = "par";
} else {
    par_impar = "impar";
}

// Validar se o número é negativo ou positivo
if (resultado < 0){
    positivo_negativo = "negativo";
} else if (resultado > 0){
    positivo_negativo = "positivo";
} else {
    positivo_negativo = "zero";
}

// Validar se o número é inteiro ou decimal
if (resultado % 1 == 0){
    inteiro_decimal = "inteiro";
} else {
    inteiro_decimal = "decimal";
}

// Retornar resultado para o usuário
Console.WriteLine($"O resultado da operação é {resultado}, sendo um número {par_impar}, {positivo_negativo}, {inteiro_decimal}");
