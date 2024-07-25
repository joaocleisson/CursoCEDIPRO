// 4 - Leia uma matriz de tamanho 3 × 3. Em seguida, imprima a soma dos valores contidos em sua diagonal principal.

using System.Globalization;

float[,] somaDiagonal = new float[3,3];
float soma = 0;
// Iniciar o programa de forma mais organizada
Console.WriteLine("\n**************************************************************************************************");
Console.WriteLine("Vamos iniciar o exercício 4. Matriz 3x3 para somar valores da diagonal principal.");

// for com a função GetLength, que permite pegar os valores das linhas ou das colunas
for(int linhas = 0; linhas < somaDiagonal.GetLength(0); linhas++)
{
    for(int colunas = 0; colunas < somaDiagonal.GetLength(1); colunas++)
    {
        Console.Write($"Digite o valor para a linha {linhas+1}, coluna {colunas+1}: ");
        string? valor = Console.ReadLine();
        if(float.TryParse(valor, NumberStyles.Any, CultureInfo.InvariantCulture, out float valorConvertido)){
            somaDiagonal[linhas,colunas] = valorConvertido;
            // Console.WriteLine(somaDiagonal[linhas,colunas]);
            if(linhas == colunas){
                soma += valorConvertido;
            }
        } else {
            Console.WriteLine("Entrada inválida. Por favor, entre com um número válido.");
            colunas--;
        }
    }
}
Console.WriteLine("\nMatriz gerada com os números digitados.");
Console.WriteLine("________");
for(int linhas = 0; linhas < somaDiagonal.GetLength(0); linhas++)
{
    Console.Write("|");
    for(int colunas = 0; colunas < somaDiagonal.GetLength(1); colunas++)
    {
        Console.Write($"{somaDiagonal[linhas,colunas]}|");
    }
    Console.WriteLine("");
}
Console.WriteLine($"A soma dos valores da diagonal principal é: {soma}");