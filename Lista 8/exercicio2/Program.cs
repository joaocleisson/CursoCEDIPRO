using System;
namespace exercicio2;
class Program
{
    static void Main()
    {
        // Iniciar o programa
        Console.WriteLine("=======================================================");
        Tv assistirTv = new Tv();

        // Exibe o estado inicial da TV
        assistirTv.ExibirEstado();

        // Testa as funcionalidades
        assistirTv.MudarCanal(15);  // Mudar para um canal válido
        assistirTv.AumentarVolume(); // Aumenta o volume
        assistirTv.AumentarVolume(); // Aumenta o volume novamente
        assistirTv.DiminuirVolume(); // Diminui o volume

        assistirTv.MudarCanal(105); // Tenta mudar para um canal inválido
        assistirTv.DiminuirVolume(); // Diminui o volume

        // Exibe o estado final da TV
        assistirTv.ExibirEstado();
    }
}