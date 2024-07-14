// Todos os exercícios são para serem feitos com uso de laço de repetição (do while, while ou for).

// Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido 
// e continue pedindo até que o usuário informe um valor válido.
using System.Globalization;

// variável para receber o valor registrado e mostrar para o usuário no final do programa
float nota;

// Exercício com Do - While
Console.WriteLine("\n**************************************************************************************************");
Console.WriteLine("Vamos iniciar com um exemplo de Do - While.");

// Pedir ao usuário que entre com um número
Console.Write("Digite uma nota (de 0 a 10): ");
string? nota_dig = Console.ReadLine();

// Converter de string para float
if (!float.TryParse(nota_dig, NumberStyles.Any,  CultureInfo.InvariantCulture, out float nota_convertida)){
    Console.WriteLine("Valor inválido. o Programa será finalizado.");
    Environment.Exit(0);
} else {
    // Verificar se o valor digitado é valido
    nota = nota_convertida;
    if (nota < 0 || nota > 10){
        // Laço até o valor digitado ser válido
        Console.WriteLine("+=================================================================================================+"); // Apenas para organização do texto
        do {
            Console.Write($"Valor inválido. Você digitou o Nº {nota}. Para registrar a nota, digite um número de 0 a 10: ");
            string? nota_dig2 = Console.ReadLine();
            Console.WriteLine("+=================================================================================================+"); // Apenas para organização do texto
            // Converter de string para float
            if (!float.TryParse(nota_dig2, NumberStyles.Any,  CultureInfo.InvariantCulture, out float nota_convertida_2)){
                nota = nota_convertida_2;
                Console.WriteLine("Valor inválido. o Programa será finalizado.");
                Environment.Exit(0);
            } else {
                nota = nota_convertida_2;
            }
        } while (nota < 0 || nota > 10);
    }
Console.WriteLine($"Nota resgitrada com sucesso. Valor da nota: {nota}.");
}

// Exercício com While
Console.WriteLine("\n**************************************************************************************************");
Console.WriteLine("Agora, vamos a outro exemplo com o While.");

// Pedir ao usuário que entre com um número
Console.Write("Digite uma nota (de 0 a 10): ");
string? nota_dig_ex_2 = Console.ReadLine(); // nota_dig_ex_2 = nota digitada exemplo 2
// Converter de string para float
if (!float.TryParse(nota_dig_ex_2, NumberStyles.Any, CultureInfo.InvariantCulture, out float nota_convertida_ex_2)){ // nota_convertida_ex_2 = nota convertida exemplo 2
    Console.WriteLine("Valor inválido (vazio, branco ou nulo). o Programa será finalizado.");
} else {
    nota = nota_convertida_ex_2;
    Console.WriteLine("+=================================================================================================+"); // Apenas para organização do texto
        while (nota < 0 || nota > 10)
        {
            Console.Write($"Valor inválido. Você digitou o Nº {nota}. Para registrar a nota, digite um número de 0 a 10: ");
            string? nota_dig_ex_2_seg = Console.ReadLine(); // nota_con_ex_2_seg = nota digitada exemplo 2 - segunda tentativa em diante
            Console.WriteLine("+=================================================================================================+"); // Apenas para organização do texto
            if (!float.TryParse(nota_dig_ex_2_seg, NumberStyles.Any,  CultureInfo.InvariantCulture, out float nota_con_ex2)){ // nota_con_ex2 = nota convertida exemplo 2 - segunda tentativa em diante
                nota = nota_con_ex2;
                Console.WriteLine("Valor inválido. o Programa será finalizado.");
                Environment.Exit(0);
            } else {
                nota = nota_con_ex2;
            }
        }
    Console.WriteLine($"Nota resgitrada com sucesso. Valor da nota: {nota}.");
}

// Exercício com For
Console.WriteLine("\n**************************************************************************************************");
Console.WriteLine("Agora, vamos a outro exemplo com o For.");

// Pedir ao usuário que entre com um número
Console.Write("Digite uma nota (de 0 a 10): ");
string? nota_dig_ex_3 = Console.ReadLine();
// Converter de string para float
if (!float.TryParse(nota_dig_ex_3, NumberStyles.Any, CultureInfo.InvariantCulture, out float nota_convertida_ex_3)){
    Console.WriteLine("Valor inválido (vazio, branco ou nulo). o Programa será finalizado.");
} else {
    nota = nota_convertida_ex_3;
    Console.WriteLine("+=================================================================================================+"); // Apenas para organização do texto
        for (; nota < 0 || nota > 10; )
        {
            Console.Write($"Valor inválido. Você digitou o Nº {nota}. Para registrar a nota, digite um número de 0 a 10: ");
            string? nota_dig_ex_3_seg = Console.ReadLine();
            Console.WriteLine("+=================================================================================================+"); // Apenas para organização do texto
            if (!float.TryParse(nota_dig_ex_3_seg, NumberStyles.Any,  CultureInfo.InvariantCulture, out float nota_con_ex3)){
                nota = nota_con_ex3;
                Console.WriteLine("Valor inválido. o Programa será finalizado.");
                Environment.Exit(0);
            } else {
                nota = nota_con_ex3;
            }
        }
    Console.WriteLine($"Nota resgitrada com sucesso. Valor da nota: {nota}.");
}