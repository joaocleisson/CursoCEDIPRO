// See https://aka.ms/new-console-template for more information

// 5. Faça um Programa que leia três números e mostre o maior deles (digite apenas números diferentes).

// Variáveis n1_dig, n2_dig e n3_dig = número 1, número 2 e número 3 digitados pelo usuário
// Variáveis n1_dig_seg, n2_dig_seg e n3_dig_seg = número 1, número 2 e número 3 digitados pela segunda vez pelo usuário
// Variáveis num1, num2 e num3 = variáveis que receberão o valor na primeira tentativa de conversão
// Variáveis num1_seg, num2_seg e num3_seg = variáveis que receberão o valor na segunda tentativa de conversão
using System.Globalization;

double n1, n2, n3;

Console.Write("Digite o primeir número: ");
string? n1_dig = Console.ReadLine();
if (!double.TryParse(n1_dig, NumberStyles.Any, CultureInfo.InvariantCulture, out double num1)){
    Console.WriteLine("Digite um número válido: ");
    string? n1_dig_seg = Console.ReadLine();
    if (!double.TryParse(n1_dig_seg, NumberStyles.Any, CultureInfo.InvariantCulture, out double num1_seg)){
        Console.WriteLine("Você não digitou um número válido, o programa será encerrado.");
        Environment.Exit(0);
    } else {
        n1 = num1_seg;
        Console.WriteLine(n1);
    }
} else {
    n1 = num1;
}

Console.WriteLine("Digite o segundo número: ");
string? n2_dig = Console.ReadLine();
if (!double.TryParse(n2_dig, NumberStyles.Any, CultureInfo.InvariantCulture, out double num2)){
    Console.WriteLine("Digite um número válido: ");
    string? n2_dig_seg = Console.ReadLine();
    if (!double.TryParse(n2_dig_seg, NumberStyles.Any, CultureInfo.InvariantCulture, out double num2_seg)){
        Console.WriteLine("Você não digitou um número válido. O programa será encerrado.");
        Environment.Exit(0);
    } else {
        n2 = num2_seg;
        Console.WriteLine(n2);
    }
} else {
    n2 = num2;
}

if (n2 == n1){
    Console.WriteLine("Digite um número diferente do primeiro: ");
    string? n2_dif_dig = Console.ReadLine();
    if (!double.TryParse(n2_dif_dig, NumberStyles.Any, CultureInfo.InvariantCulture, out double num2_dif)){
       Console.WriteLine("Digite um número válido: ");
       string? n2_dif_dig_seg = Console.ReadLine();
       if (!double.TryParse(n2_dif_dig_seg, NumberStyles.Any, CultureInfo.InvariantCulture, out double num2_dif_seg)){
         Console.WriteLine("Você não digitou um número válido. O programa será encerrado.");
        Environment.Exit(0);
       }else {
            n2 = num2_dif_seg;
            Console.WriteLine(n2);
        }
    } else {
        n2 = num2_dif;
        Console.WriteLine(n2);
    }
}

Console.WriteLine("Digite o terceiro número: ");
string? n3_dig = Console.ReadLine();
if (!double.TryParse(n3_dig, NumberStyles.Any, CultureInfo.InvariantCulture, out double num3)){
    Console.WriteLine("Digite um número válido: ");
    string? n3_dig_seg = Console.ReadLine();
    if (!double.TryParse(n3_dig_seg, NumberStyles.Any, CultureInfo.InvariantCulture, out double num3_seg)){
        Console.WriteLine("Você não digitou um número válido. O programa será encerrado.");
        Environment.Exit(0);
    }
}

if (num3 == num1 || num3 == num2){
    Console.WriteLine("Digite um número diferente do primeiro e do segundo: ");
    string? n3_dif_dig = Console.ReadLine();
    if (!double.TryParse(n3_dif_dig, NumberStyles.Any, CultureInfo.InvariantCulture, out double num3_dif)){
       Console.WriteLine("Digite um número válido: ");
       string? n3_dif_dig_seg = Console.ReadLine();
       if (!double.TryParse(n3_dif_dig_seg, NumberStyles.Any, CultureInfo.InvariantCulture, out double num3_dif_seg)){
         Console.WriteLine("Você não digitou um número válido. O programa será encerrado.");
        Environment.Exit(0);
       }
    }
}
if (n1 > n2 && n1 > n3){
    Console.WriteLine($"{n1} é o maior número");
} else if (n2 > n1 && n2 > n3){
    Console.WriteLine($"{n2} é o maior número");
} else {
    Console.WriteLine($"{n3} é o maior número");
}