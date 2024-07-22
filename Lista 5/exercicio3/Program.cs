// 3. Faça um Programa que leia 20 números inteiros e armazene-os num vetor. 
//    Armazene os números pares no vetor PAR e os números IMPARES no vetor impar. Imprima os três vetores.

using System.Globalization;

// Iniciar o programa de forma mais organizada
Console.WriteLine("\n**************************************************************************************************");
Console.WriteLine("Vamos iniciar o exercício de vetor de números pares e ímpares");

// Criar o vetor para comportar os 20 números
double[] Numeros = new double [20];
double[] Par = new double [20];
double[] Impar = new double [20];


// Solicitar que o usuário digite os números
for (int i = 0; i < Numeros.Length; ++i)
{
    Console.Write($"Digite o número {i+1} de 20: "); // como o índice começa com zero, para usar o índice como indicador de números digitados tem que pegar o total de elementos e somar 1

    // Resgatar os valores digitados e validar conversão
    string? numero = Console.ReadLine();
    if (!double.TryParse(numero, NumberStyles.Any, CultureInfo.InvariantCulture, out double numeroConvertido))
    {
        Console.WriteLine("Valor inválido. Digite um número válido.");
        i--;
    }
    else
    {
        Numeros[i] = numeroConvertido;
        if (Numeros[i] % 2 == 0){
            Par[i] = Numeros[i];
        } else {
            Impar[i] = Numeros[i];
        }
    }
}

// Imprimir vetor geral
Console.WriteLine("---------------------------------------");
Console.WriteLine("\nVetor geral.");
foreach (var item in Numeros)
{
    if (item == 0){
        continue;
    } else {
        Console.WriteLine(item);
    }
}

// Imprimir vetor par
Console.WriteLine("---------------------------------------");
Console.WriteLine("\nVetor par.");
foreach (var item in Par)
{
    if (item == 0){
        continue;
    } else {
        Console.WriteLine(item);
    }
}

// Imprimir vetor ímpar
Console.WriteLine("---------------------------------------");
Console.WriteLine("\nVetor ímpar.");
foreach (var item in Impar)
{
    if (item == 0){
        continue;
    } else {
        Console.WriteLine(item);
    }
}