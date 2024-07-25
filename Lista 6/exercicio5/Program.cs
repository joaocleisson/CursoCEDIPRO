// 5. Leia uma matriz de tamanho 3 × 3. Em seguida, imprima a soma dos valores contidos em sua diagonal secundária.

using System.Globalization;

// Iniciar o exercício de forma mais organizada
Console.WriteLine("\n**************************************************************************************************");
Console.WriteLine("Vamos iniciar o exercício 5. Matriz 3x3 para somar valores da diagonal secundária.");

// Criar matriz e variável para armazenar os valores
float[,] somarDiagonalSecundaria = new float[3,3];
float soma = 0;

// for com a função GetLength, que permite pegar os valores das linhas ou das colunas. Colocando 0 pega as linhas, 1 pega as colunas
for(int linhas = 0; linhas < somarDiagonalSecundaria.GetLength(0); linhas++)
{
    for(int colunas = 0; colunas < somarDiagonalSecundaria.GetLength(1); colunas++)
    {
        // Solicitar que o usuário digite os valores
        Console.Write($"Digite o valor para a linha {linhas+1}, coluna {colunas+1}: ");
        // Resgatar o valor digitado e armazenar na variável valor
        string? valor = Console.ReadLine();
        // Verificar se o valor digitado é um número e armazenar na variável valorConvertido. 
        // Se não for um número, a entrada do usuário é inválida e ele deve repetir o processo
        if(float.TryParse(valor, NumberStyles.Any, CultureInfo.InvariantCulture, out float valorConvertido)){
            somarDiagonalSecundaria[linhas,colunas] = valorConvertido;
            // Para descobrir a diagonal secundária, soma-se a posição da linha e coluna e verifica se é igual a soma 
            // da linha inteira - 1. Ex. Primeira linha = 0, terceira coluna = 2, soma da linha inteira = 0 + 1 + 2 = 3, - 1 = 2
            if(linhas + colunas == somarDiagonalSecundaria.GetLength(0) - 1){
                soma += valorConvertido;
            }
        } else {
            Console.WriteLine("Entrada inválida. Por favor, entre com um número válido.");
            colunas--; // para voltar para a coluna anterior e repetir o processo
        }
    }
}
// Console.WriteLine(somarDiagonalSecundaria.GetLength(0)); --> verificar o tamanho da matriz

Console.WriteLine("\nMatriz gerada com os números digitados.");
Console.WriteLine("________");
for(int linhas = 0; linhas < somarDiagonalSecundaria.GetLength(0); linhas++)
{
    Console.Write("|");
    for(int colunas = 0; colunas < somarDiagonalSecundaria.GetLength(1); colunas++)
    {
        Console.Write($"{somarDiagonalSecundaria[linhas,colunas]}|");
    }
    Console.WriteLine("");
}
Console.WriteLine($"A soma dos valores da diagonal principal é: {soma}");