// Criar um jogo de adivinhar o número, com 3 níveis: Fácil (1-10 e 3 chances), Médio (1-50 e 4 chances) e Difícil (1-100 e 5 chances).
// O usuário poderá escolher a dificuldade com letras maiúsculas ou minúsculas.Não aceitar valores fora da dificuldade.
// Se o usuário perder, informar a ele qual era o número que foi sorteado. Se o usuário ganhar, informar a ele que ganhou.

using System.Collections;
using System.Globalization;

// Iniciar a apresentação do jogo de forma mais organizada
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("======================================================================");
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("-------------------------Vamos jogar! 🎮🎮🎮--------------------------");
Console.WriteLine("======================================================================");
Console.ResetColor();
// Criar variáveis e vetores para funcionamento do programa
string dificuldade;
var valor = new Random();
int minValue = 0, maxValue = 0;
int valorGerado = 0;
int valorEscolhido;
int[] valoresDigitados = new int[5];
int tentativas = 0;

// Escolher o nível do jogo e definir os valores mínimo e máximo, conforme o nível escolhido
Console.WriteLine("\nConfigurações para o jogo 🔧🔧🔧");
while (true)
{
    Console.Write("Selecione a dificuldade: (F)ácil, (M)édio ou (D)ifícil. ➡  ");
    string? entrada = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(entrada)){
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("⚠ Atenção: Entrada inválida. Selecione o nível do jogo digitando a letra indicada para cada nível.");
        Console.ResetColor();
        continue;
    }
    dificuldade = entrada.ToUpper();
    if (dificuldade == "F" || dificuldade == "M" || dificuldade == "D" ){
        if (dificuldade == "F"){
            Console.WriteLine($"Nível selecionado: Fácil. Tá com medinho, tá? 🤣🤣🤣");
            minValue = 1; maxValue = 10;
            valorGerado = valor.Next(minValue,maxValue + 1);
            tentativas = 3;
        } else if (dificuldade == "M"){
            Console.WriteLine($"Nível selecionado: Médio. Você vai passar um pouco de aperto, tá preparado? 😬😬😬");
            minValue = 1; maxValue = 50;
            valorGerado = valor.Next(minValue,maxValue + 1); // + 1 é para incluir o valor superior no processo de geração do código
            tentativas = 4;
        } else if (dificuldade == "D"){
            Console.WriteLine($"Nível selecionado: Difícil. Você deve ter se enganado ou está confiante demais 🤔🤔🤔, mas vamos lá...🫣🫣🫣");
            minValue = 1; maxValue = 100;
            valorGerado = valor.Next(minValue,maxValue);
            tentativas = 5;
        }
        break;
    } else {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("⚠ Atenção: Entrada inválida. Selecione o nível do jogo digitando a letra indicada para cada nível.");
        Console.ResetColor();
    }
}

// Laço para entrar nas configurações do jogo conforme nível escolhido pelo jogador
switch (dificuldade)
{
    case "F":
        Console.WriteLine("Vamos pro Jogo!\nTente adivinhar o número de 1 a 10. Você terá 3 chances.");
        // Console.WriteLine(valorGerado); // --> para testar o valor aleatório
        for (int contador = 0; contador < 3; contador++)
        {
            while (true)
            {
                Console.WriteLine($"Nº de tentativas: {tentativas}");
                Console.Write("Digite o seu número inteiro. ➡  ");
                string? valorDigitado = Console.ReadLine();
                if(!int.TryParse(valorDigitado, out int valorConvertido)){
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("⚠ Atenção: Entrada inválida. Digite um número inteiro de 1 a 10.");
                    Console.ResetColor();
                    continue;
                } else {
                    /* completar depois
                    if (Array.Exists(valoresDigitados, element => element == valorEscolhido)){
                        Console.WriteLine("Ja tentou esse número. Tente novamente!");
                        continue;
                    }*/
                    if (valorConvertido < minValue || valorConvertido > maxValue){
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("⚠ Atenção: Entrada inválida. Digite um número inteiro de 1 a 10.");
                        Console.ResetColor();
                        continue;
                    } else {
                        valorEscolhido = valorConvertido;
                        tentativas--;
                        valoresDigitados[contador] = valorEscolhido; // --> para testar o valor digitado[]
                        break;
                    }
                }
            }
            if (valorEscolhido == valorGerado){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Parabéns, você acertou o número! 🎉🎉🎉🏆🥇");
                Console.ResetColor();
                break;
            } else {
                if (contador <= 1) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Você errou, tente novamente! 🫣");
                    Console.ResetColor();
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("☠  Não foi dessa vez, o número era: " + valorGerado);
                    Console.ResetColor();
                }
            }
        }
    break;

    case "M":
        Console.WriteLine("Vamos pro Jogo!\nTente adivinhar o número de 1 a 50. Você terá 4 chances.");
        // Console.WriteLine(valorGerado); //--> para testar o valor aleatório
        for (int contador = 0; contador < 4; contador++)
        {
            while (true)
            {
                Console.WriteLine($"Nº de tentativas: {tentativas}");
                Console.Write("Digite o seu número inteiro. ➡  ");
                string? valorDigitado = Console.ReadLine();
                if(!int.TryParse(valorDigitado, out int valorConvertido)){
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("⚠ Atenção: Entrada inválida. Digite um número inteiro de 1 a 50.");
                    Console.ResetColor();
                    continue;
                } else {
                    if (valorConvertido < minValue || valorConvertido > maxValue){
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("⚠ Atenção: Entrada inválida. Digite um número inteiro de 1 a 50.");
                        Console.ResetColor();
                        continue;
                    } else {
                        valorEscolhido = valorConvertido;
                        tentativas--;
                        break;
                    }
                }
            }
            if (valorEscolhido == valorGerado){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Parabéns, você acertou o número! 🎉🎉🎉🏆🥇");
                Console.ResetColor();
                break;
            } else {
                if (contador <= 2) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Você errou, tente novamente! 🫣");
                    Console.ResetColor();
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("☠  Não foi dessa vez, o número era: " + valorGerado);
                    Console.ResetColor();
                }
            }
        }
    break;

    case "D":
    Console.WriteLine("Vamos pro Jogo!\nTente adivinhar o número de 1 a 100. Você terá 5 chances.");
        //Console.WriteLine(valorGerado); //--> para testar o valor aleatório
        for (int contador = 0; contador < 5; contador++)
        {
            while (true)
            {
                Console.WriteLine($"Nº de tentativas: {tentativas}");
                Console.Write("Digite o seu número inteiro. ➡  ");
                string? valorDigitado = Console.ReadLine();
                if(!int.TryParse(valorDigitado, out int valorConvertido)){
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("⚠ Atenção: Entrada inválida. Digite um número inteiro de 1 a 100.");
                    Console.ResetColor();
                    continue;
                } else {
                    if (valorConvertido < minValue || valorConvertido > maxValue){
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("⚠ Atenção: Entrada inválida. Digite um número inteiro de 1 a 100.");
                        Console.ResetColor();
                        continue;
                    } else {
                        valorEscolhido = valorConvertido;
                        tentativas--;
                        break;
                    }
                }
            }
            if (valorEscolhido == valorGerado){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Parabéns, você acertou o número! 🎉🎉🎉🏆🥇");
                Console.ResetColor();
                break;
            } else {
                if (contador <= 3) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Você errou, tente novamente! 🫣");
                    Console.ResetColor();
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("☠   Não foi dessa vez, o número era: " + valorGerado);
                    Console.ResetColor();
                }
            }
        }
    break;
}
