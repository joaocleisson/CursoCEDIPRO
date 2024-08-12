namespace exercicio2;
using System;

public class Tv
{
    // Atributos da classe
    private int _canal;
    private int _volume;
    private const int CanalMinimo = 1;
    private const int CanalMaximo = 100;
    private const int VolumeMinimo = 0;
    private const int VolumeMaximo = 50;

    // Construtor padrão que inicializa a TV com o canal 1 e volume 10
    public Tv()
    {
        _canal = CanalMinimo;
        _volume = 10;
    }

    // Método para mudar o canal
    public void MudarCanal(int novoCanal)
    {
        if (novoCanal >= CanalMinimo && novoCanal <= CanalMaximo)
        {
            _canal = novoCanal;
            Console.WriteLine("Canal alterado para: " + _canal);
        }
        else
        {
            Console.WriteLine("Número de canal inválido. Escolha um canal entre " + CanalMinimo + " e " + CanalMaximo + ".");
        }
    }

    // Método para aumentar o volume
    public void AumentarVolume()
    {
        if (_volume < VolumeMaximo)
        {
            _volume++;
            Console.WriteLine("Volume aumentado para: " + _volume);
        }
        else
        {
            Console.WriteLine("Volume já está no máximo (" + VolumeMaximo + ").");
        }
    }

    // Método para diminuir o volume
    public void DiminuirVolume()
    {
        if (_volume > VolumeMinimo)
        {
            _volume--;
            Console.WriteLine("Volume diminuído para: " + _volume);
        }
        else
        {
            Console.WriteLine("Volume já está no mínimo (" + VolumeMinimo + ").");
        }
    }

    // Método para exibir o estado atual da TV
    public void ExibirEstado()
    {
        Console.WriteLine("Canal atual: " + _canal);
        Console.WriteLine("Volume atual: " + _volume);
    }
}
