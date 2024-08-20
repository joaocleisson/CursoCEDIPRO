namespace projeto1;

public class Escritor
{
    public string Nome { get; set;}
    public string Sobrenome { get; set;}
    public string Biografia { get; set;}
    public string Tipo { get; set;}
    public void Escrever()
    {
        Console.WriteLine("Escrevendo um texto...");
    }
}