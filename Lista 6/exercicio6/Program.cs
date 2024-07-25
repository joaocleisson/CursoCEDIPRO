// 6. Faça um programa que permita ao usuário entrar com uma matriz de tamanho 3 × 3 de números inteiros. 
//    Em seguida, calcule um vetor contendo três posições, em que cada posição deverá armazenar a soma dos números de cada coluna da matriz. 
//    Exiba na tela esse array. Por exemplo, a matriz 
//    5 −8 10
//    1  2 15
//    25 10 7
//    deverá gerar o vetor:
//    31 4 32

using System.Globalization;

// Iniciar o programa de forma mais organizada
Console.WriteLine("Programa para calcular a soma de cada coluna da matriz");
Console.WriteLine("*******************************************************************************");

// Criar matriz 3x3 e vetor para armazenar a soma de cada coluna
int[,] matriz = new int[3, 3];
int[] vetor = new int[3];

// Entrada de dados e preenchimento da matriz
for (int linhas = 0; linhas < matriz.GetLength(0); linhas++)
{
    for(int colunas = 0; colunas < matriz.GetLength(1); colunas++)
    {
        // Usuário insere os valores
        Console.Write($"Entre com o valor para a linha {linhas+1} e coluna {colunas+1}: ");
        // Resgatar o valor e gravar na variável valor
        string? valor = Console.ReadLine();
        if(int.TryParse(valor, NumberStyles.Any, CultureInfo.InvariantCulture, out int valorConvertido)){
            matriz[linhas,colunas] = valorConvertido;
            if(colunas == 0){
                vetor[0] += valorConvertido;
            } else if (colunas == 1){
                vetor[1] += valorConvertido;
            } else {
                vetor[2] += valorConvertido;
            }
        } else {
            Console.WriteLine("Entrada inválida. Tente novamente.");
            colunas--;
        }
    }
}

Console.Write("\nVetor com a soma de cada coluna da matriz: ");
foreach (var item in vetor){
    Console.Write($"{item}, ");
}