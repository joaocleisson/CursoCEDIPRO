// Faça um Programa que leia um vetor de 10 números reais e mostre-os na ordem inversa.
using System.Globalization;

// Iniciar o programa de forma mais organizada
Console.WriteLine("\n**************************************************************************************************");
Console.WriteLine("Vamos iniciar o exercício de vetor");

// Criar o vetor para comportar os 10 números
double[] Numeros = new double [10];

// Solicitar que o usuário digite os números
for (int i = 0; i < Numeros.Length; ++i)
{
    Console.Write($"Digite o número {i+1} de 10: "); // como o índice começa com zero, para usar o índice como indicador de números digitados tem que pegar o total de elementos e somar 1

    // Resgatar os valores digitados e validar conversão
    string? numero = Console.ReadLine();
    if (!double.TryParse(numero, NumberStyles.Any, CultureInfo.InvariantCulture, out double numeroConvertido))
    {
        Console.WriteLine("Valor inválido. O programa será finalizado.");
        Environment.Exit(0);
    }
    else
    {
        Numeros[i] = numeroConvertido;
        // Console.WriteLine(Numeros[i]); Conferir se os valores estavam sendo apresentado corretamente
    }
}
//Console.WriteLine(Numeros.Length); Para verificar a quantidade de índices

// Exibir os números na ordem inversa
Console.WriteLine("\nNúmeros na ordem inversa:");
for (int i = Numeros.Length -1; i >= 0; i--) // como o índice começa com zero, para acessar o último índice tem que pegar o total de elementos e diminuir 1
{
    // Listar os números na ordem inversa utilizando o índice do vetor
    Console.WriteLine(Numeros[i]);
}