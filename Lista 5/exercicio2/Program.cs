// Faça um Programa que leia um vetor de 10 caracteres, e diga quantas consoantes foram lidas. 
// Imprima as consoantes (Entenda que serão digitados somente letras do alfabeto sem acento).

// Iniciar o programa de forma mais organizada
Console.WriteLine("\n**************************************************************************************************");
Console.WriteLine("Vamos iniciar o exercício de vetor de caracteres");

// Criar o vetor para inserir os 10 caracteres
char[] caracteres = new char[10];
string consoantes = "";
int contadorConsoantes = 0;

// Solicitar que o usuário digite os caracteres
for (int i = 0; i < caracteres.Length; i++)
{
    Console.Write($"Digite o caracter {i + 1} de 10: ");
    string? entrada = Console.ReadLine();

    // Validar se não é nulo ou vazio, verificar se digitou apenas um caracter e se é letra
    if (!string.IsNullOrEmpty(entrada) && entrada.Length == 1 && char.IsLetter(entrada[0]))// entrada[0] verifica se o primeiro caracter da string é letra
    {
        caracteres[i] = char.ToLower(entrada[0]);

        // Verificar se o caractere é uma consoante
        if (caracteres[i] == 'b' || caracteres[i] == 'C' || caracteres[i] == 'd' || caracteres[i] == 'f' || caracteres[i] == 'g' ||
            caracteres[i] == 'h' || caracteres[i] == 'j' || caracteres[i] == 'k' || caracteres[i] == 'l' || caracteres[i] == 'm' ||
            caracteres[i] == 'n' || caracteres[i] == 'p' || caracteres[i] == 'q' || caracteres[i] == 'r' || caracteres[i] == 's' ||
            caracteres[i] == 't' || caracteres[i] == 'v' || caracteres[i] == 'w' || caracteres[i] == 'x' || caracteres[i] == 'y' ||
            caracteres[i] == 'z')
            {
                consoantes += caracteres[i];
                contadorConsoantes++;
            }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite uma letra.");
            i--; // Para repetir a iteração para o mesmo índice
        }
}

// Exibição do número de consoantes e das consoantes
Console.WriteLine($"\nNúmero de consoantes inseridas: {contadorConsoantes}");
if (contadorConsoantes > 0)
{
    Console.WriteLine($"Consoantes: {consoantes}");
} else {
    Console.WriteLine("Não foi inserido consoantes.");
}