namespace projeto1;

public class EscritorLivro : Escritor, IVlogger
{
    public void Vlog()
    {
        Console.WriteLine("Gravando um vlog sobre o livro...");
    }
}