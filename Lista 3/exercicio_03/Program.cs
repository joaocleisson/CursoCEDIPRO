// See https://aka.ms/new-console-template for more information

// 3. Faça um Programa que verifique se uma letra digitada é "F" ou "M".
//    Conforme a letra escrever: F - Feminino, M - Masculino, Sexo Inválido.
Console.Write("Digite uma letra: ");
string? valor_digitado = Console.ReadLine();
if (!char.TryParse(valor_digitado, out char valor) || valor != 'f' && valor != 'F' && valor != 'm' && valor != 'M'){
    Console.WriteLine("Você não digitou uma letra ou digitou uma letra inválida.");
} else {
    if (valor == 'f' || valor == 'F'){
        Console.WriteLine("F - Feminino");
    } else if (valor == 'm' || valor == 'M'){
        Console.WriteLine("M - Masculino");
    } else {
        Console.WriteLine("Sexo Inválido");
    }
}
