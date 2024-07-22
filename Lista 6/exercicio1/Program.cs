// Faça um programa que leia uma matriz de tamanho 4 × 4.
// Imprima na tela o maior valor contido nessa matriz e a sua localização (linha e coluna).

using System.Globalization;
// Criar a matriz 4x4 (4 linhas e 4 colunas)

float[,] matrizMaiorNumero = new float [4,4];

// Iniciar o programa de forma mais organizada
Console.WriteLine("\n**************************************************************************************************");
Console.WriteLine("Vamos iniciar o exercício de Matriz 4x4");

// Solicitar que usuário entre com os valores
Console.WriteLine("Digite os valores que serão incorporados na matriz.");

// Função GetLength permite pegar quantidade específica de linhas (0) ou colunas (1)
for (int linhas = 0; linhas < matrizMaiorNumero.GetLength(0); linhas++)
{
    for (int colunas = 0; colunas < matrizMaiorNumero.GetLength(1); colunas++)
    {
        // Pega o valor da variável i do for, adiciona um e utiliza como índice para digitação do usuário
        Console.Write($"\nDigite o valor da {linhas+1}ª linha, e {colunas+1}ª Coluna: "); 

        // Resgatar valores digitados e salvar na variável
        string? valor = Console.ReadLine();
        if (!float.TryParse(valor, NumberStyles.Any, CultureInfo.InvariantCulture, out float valores))
        {
            Console.WriteLine("Entrada inválida. Tente novamente.");
            colunas--; 
        } else {
            matrizMaiorNumero[linhas,colunas] = valores;
        }
    }
}

// Função GetLength permite pegar quantidade específica de linhas (0) ou colunas (1)
for (int linhas = 0; linhas < matrizMaiorNumero.GetLength(0); linhas++)
{
    for (int colunas = 0; colunas < matrizMaiorNumero.GetLength(1); colunas++)
    {
        // Primeir forma de imprimir - Um valor em cada linha
        // Console.WriteLine($"Matriz[{linhas}][{colunas}] = {matrizMaiorNumero[linhas,colunas]}");

        // Segunda forma de imprimir - Imitando disposição de uma matriz
        Console.Write($"{matrizMaiorNumero[linhas,colunas]}, ");
    }
    // apenas para quebra de linha
    Console.WriteLine();
}