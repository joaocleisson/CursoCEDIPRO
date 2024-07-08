// See https://aka.ms/new-console-template for more information
// 4. Faça um Programa que verifique se uma letra digitada é vogal ou consoante.

Console.Write("Digite uma letra: ");
char letra = char.Parse(Console.ReadLine());
if(letra == 'a' || letra == 'A' || letra == 'e' || letra == 'E' || letra == 'i' || letra == 'I' || letra == 'o' || letra == 'O' || letra == 'u' || letra == 'U'){
    Console.WriteLine("Vogal");
} else {
    Console.WriteLine("Consoante");
}
