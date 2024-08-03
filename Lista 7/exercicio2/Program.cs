// Criar um jogo da forca, onde o usuário deve tentar adivinhar uma palavra.
// O jogo deve ter várias palavras em um vetor para serem sorteadas a cada execução do programa.
// O jogo deve informar se a letra está na palavra ou se o usuário errou a letra.
// Mostrar um tracinho no lugar de cada letra da palavra que deverá ser acertada respeitando a quantidade de letras da palavra.
// Não aceitar letras repetidas, se o usuário digitar uma letra já utilizada dar a mensagem de erro e pedir outra letra.
// Mostrar na tela as letras já utilizadas pelo usuário, mostrando a letra acertada no lugar do –, ex.: palavra "saltar" e o usuário colocou letra “a” então mostrar    _ a _ _ a _ 
// Se o usuário perder, informar a ele qual era a palavra sorteada. Se o usuário ganhar, informar a ele que ganhou e a palavra sorteada.

// Array com palavras que serão utilizadas no jogo
string[] palavras = ["banana", "abacate", "pera", "morango", "uva"];
// Console.WriteLine(palavras.Length);

// Instância da classe Random, para selecionar aleatoriamente uma das palavras do array
var palavra = new Random();

// Variável para receber o número do índice do array, que foi sorteado pelo .Next, utilizando como limite de sorteio o número total de índices do array
int indiceAleatorio = palavra.Next(palavras.Length);

// Variável para receber a palavra que corresponde ao número do índice sorteado no passo anterior
string palavraSorteada = palavras[indiceAleatorio];
// Console.WriteLine(palavraSorteada); //--> para testar o processo de sorteio da palavra

// Apresentação do jogo
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("Bem vindo ao jogo da forca!\n");
Console.ResetColor();

Console.WriteLine($"A palavra sorteada possui {palavraSorteada.Length} letras. Tente adivinhar qual é palavra. Você terá {palavraSorteada.Length} chances.");

// Vetor que recebera os "tracinhos" para cada letra e depois vai recebendo as letras acertadas
string[] letras = new string[palavraSorteada.Length];
for (int i = 0; i < palavraSorteada.Length; i++)
{
    letras[i] = "_";
}

// Lista para armazenar as letras já utilizadas
// List<char> letrasUsadas = new List<char>(); --> estava assim, mas o vs code sugeriu a forma abaixo
List<char> letrasUsadas = [];

// Variável para armazenar o número de tentativas restantes baseado na quantidade de letras da palavra
int tentativasRestantes = palavraSorteada.Length;
bool ganhou = false;

// Loop para validar as tentativas, validar se o jogador acertou ou errou e mostrar o status do jogo
while (tentativasRestantes > 0 && !ganhou)
{
    // Exibir as letras adivinhadas pelo jogador
    Console.WriteLine($"Tentativas: {tentativasRestantes}");
    Console.WriteLine(String.Join(" ", letras));
    Console.WriteLine($"Letras: {palavraSorteada.Length}");
    Console.WriteLine($"Letras usadas: [ {String.Join(" ", letrasUsadas)} ]");
    Console.Write("Digite uma letra: ");

    // Criar uma variável para receber o valor digitado e Verificar se a entrada do usuário é válida
    char letraDigitada;
    while (!char.TryParse(Console.ReadLine(), out letraDigitada) || !char.IsLetter(letraDigitada) || letrasUsadas.Contains(char.ToLower(letraDigitada)))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Write("Entrada inválida ou letra já utilizada. Pressione qualquer tecla para continuar.");
        Console.ReadKey();
        Console.ResetColor();
        Console.Clear();
        Console.Write("Digite uma nova letra: ");
    }

    // Adicionar a letra digitada na lista de letras usadas
    letrasUsadas.Add(char.ToLower(letraDigitada));

    // Laço para percorrer os índices do vetor palavraSorteada e comparar cada elemento com a letra digitada. 
    // Onde houver elemento igual, será salvo no vetor letras, subtituindo o tracinho
    bool acertou = false;
    for (int i = 0; i < palavraSorteada.Length; i++)
    {
        if (palavraSorteada[i] == letraDigitada)
        {
            letras[i] = char.ToString(letraDigitada);
            acertou = true;
        }
    }

    if (!acertou)
    {
        tentativasRestantes--;
        Console.WriteLine($"Você errou!");
    }

    if (!Array.Exists(letras, letra => letra == "_"))
    {
        ganhou = true;
    }
    
}

if (ganhou)
{
    Console.WriteLine($"Parabéns! Você acertou a palavra: {palavraSorteada}");
}
else
{
    Console.WriteLine($"Você perdeu! A palavra era: {palavraSorteada}");
}