// See https://aka.ms/new-console-template for more information
// 1. Faça um Programa que peça um valor e mostre na tela se o valor é positivo ou negativo.

Console.WriteLine("Digite um valor inteiro: ");
string? valor_digitado = Console.ReadLine();
if (int.TryParse(valor_digitado, out int valor)){
    if (valor < 0){
        Console.WriteLine("O valor digitado é negativo");
    } else if (valor > 0 ){
        Console.WriteLine("O valor digitado é positivo");
    } else {
        Console.WriteLine("O valor digitado é zero");
    }
} else {
    Console.WriteLine("Digite um número válido.");
}