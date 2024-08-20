namespace projeto1;

public class ClubeITA : Promotor, IBodyBuilders, IVlogger
{
    public override void PromoverNaRedeSocial()
    {
        Console.WriteLine("Promovendo no Instagram para o Clube ITA.");
    }
    public override void PromoverAds()
    {
        Console.WriteLine("Promovendo com Google AdWords para o Clube ITA.");
    }
    public void Malhar()
    {
        Console.WriteLine("Malhando no Clube ITA.");
    }

    public void Vlog()
    {
        Console.WriteLine("Gravando um vlog no Clube ITA.");
    }
}