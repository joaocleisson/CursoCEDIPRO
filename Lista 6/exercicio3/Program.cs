// 3 - Leia uma matriz de tamanho 4 × 4. Em seguida, conte e escreva na tela quantos valores maiores do que 10 ela possui.

using System.Globalization;
// Criar a matriz 4x4 (4 linhas e 4 colunas)

float[,] matrizGeral = new float [1,1];
int valoresMaiorQueDez = 0;
float[] vetorMaiorQueDez = new float [16]; // Não consegui criar uma matriz sem definir quantidade de elementos

// Iniciar o programa de forma mais organizada
Console.WriteLine("\n**************************************************************************************************");
Console.WriteLine("Vamos iniciar o exercício 3. Matriz 4x4 para apurar valores maiores que 10.");

// Solicitar que usuário entre com os valores
Console.WriteLine("Digite os valores que serão incorporados na matriz.");

// Função GetLength permite pegar quantidade específica de linhas (0) ou colunas (1)
for (int linhas = 0; linhas < matrizGeral.GetLength(0); linhas++)
{
    for (int colunas = 0; colunas < matrizGeral.GetLength(1); colunas++)
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
            matrizGeral[linhas,colunas] = valores;
            if (valores > 10)
            {
                valoresMaiorQueDez++;
                // Pensar em uma forma de inserir o valor maior que 10 para exibir os valores para o usuário
            }
        }
    }
}
// Exibir a quantidade de valores maiores que 10
Console.WriteLine($"\nA matriz contém {valoresMaiorQueDez} valores maiores que 10.");
Console.WriteLine($"\n-------------------Fim do exercício----------------------\n");