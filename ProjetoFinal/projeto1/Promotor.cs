namespace projeto1;

public abstract class Promotor
{
    public string Nome { get; set;}
    public string Sobrenome { get; set;}
    public string Telefone { get; set;}
    public string CartaoVisita { get; set;}
    public string Local { get; set;}
    public abstract void PromoverNaRedeSocial();
    public abstract void PromoverAds();
}