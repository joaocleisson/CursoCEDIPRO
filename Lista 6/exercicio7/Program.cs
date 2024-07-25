// 7. Leia uma matriz de tamanho 10 × 3 com as notas de 10 alunos em três provas. Em seguida, calcule e escreva na tela o número de alunos 
//    cuja pior nota foi na prova 1, o número de alunos cuja pior nota foi na prova 2 e o número de alunos cuja pior nota foi na prova 3.

using System.Globalization;

// Iniciar o programa de forma mais organizada
Console.WriteLine("-------------------------Início do programa-------------------------");
Console.WriteLine("\nPrograma para identificar alunos com piores notas em cada uma das três provas aplicadas");

// Criar matriz e variáveis para armazenar valores do programa
float[,] notas = new float[10,3];
int piorNotaPrimeiraProva = 0;
int piorNotaSegundaProva = 0;
int piorNotaTerceiraProva = 0;

for (int linhas = 0; linhas < notas.GetLength(0); linhas++)
{
    for (int colunas = 0; colunas < notas.GetLength(1); colunas++)
    {
        Console.Write($"Digite a {colunas+1}ª nota do {linhas+1}º aluno: ");
        string? notaDigitada = Console.ReadLine();
        if (float.TryParse(notaDigitada, NumberStyles.Any, CultureInfo.InvariantCulture, out float notaConvertida)){
            notas[linhas,colunas] = notaConvertida;
        } else {
            Console.WriteLine("Entrada inválida. Tente novamente.");
            colunas--;
        }
    }
}
Console.WriteLine("####################################################");

for (int linhas = 0; linhas < notas.GetLength(0); linhas++)
{
    if (notas[linhas,0] < notas[linhas, 1] && notas[linhas, 0] < notas[linhas, 2]){
        piorNotaPrimeiraProva++;
    } else if (notas[linhas, 1] < notas[linhas, 0] && notas[linhas, 1] < notas[linhas, 2]){
        piorNotaSegundaProva++;
    } else if (notas[linhas, 2] < notas[linhas, 0] && notas[linhas, 2] < notas[linhas, 1]){
        piorNotaTerceiraProva++;
    } 
}
Console.WriteLine("\nAlunos com piores notas na primeira prova: " + piorNotaPrimeiraProva);
Console.WriteLine("Alunos com piores notas na segunda prova: " + piorNotaSegundaProva);
Console.WriteLine("Alunos com piores notas na terceira prova: " + piorNotaTerceiraProva);
Console.WriteLine("-------------------------Fim do programa-------------------------");