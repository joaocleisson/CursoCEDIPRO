namespace projeto1;

public class EscritorBlog : Escritor, IVlogger
{
    public void Vlog()
    {
        Console.WriteLine("Gravando um vlog para o blog...");
    }
}