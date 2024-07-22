// 2. Faça um programa que declare uma matriz de tamanho 5 × 5.
//    Preencha com 1 a diagonal principal e com 0 os demais elementos. Ao final, escreva a matriz obtida na tela.

using System.Globalization;
// Criar a matriz 5x5 (5 linhas e 5 colunas)

float[,] matrizDiagonalIgualAUm = new float [5,5];

// Iniciar o programa de forma mais organizada
Console.WriteLine("\n**************************************************************************************************");
Console.WriteLine("Vamos iniciar o exercício de Matriz 5x5, determinando valores da diagonal igual a um e o restante igual a zero");

// Função GetLength permite pegar quantidade específica de linhas (0) ou colunas (1)
for (int linhas = 0; linhas < matrizDiagonalIgualAUm.GetLength(0); linhas++)
{
    for (int colunas = 0; colunas < matrizDiagonalIgualAUm.GetLength(1); colunas++)
    {
        if (linhas == colunas)
        {
            matrizDiagonalIgualAUm[linhas,colunas] = 1;
        } else {
            matrizDiagonalIgualAUm[linhas,colunas] = 0;
        }
    }

}

// Função GetLength permite pegar quantidade específica de linhas (0) ou colunas (1)
for (int linhas = 0; linhas < matrizDiagonalIgualAUm.GetLength(0); linhas++)
{
    for (int colunas = 0; colunas < matrizDiagonalIgualAUm.GetLength(1); colunas++)
    {
        Console.Write($"{matrizDiagonalIgualAUm[linhas,colunas]}, ");
    }
    // apenas para quebra de linha
    Console.WriteLine();
}
Console.WriteLine($"\n-------------------Fim do exercício----------------------\n");