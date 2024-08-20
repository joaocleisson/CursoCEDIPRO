using System;
using System.Collections.Generic;
using projeto1;

public class Program
{
    public static void Main()
    {
        // Criando a lista de Escritores
        var escritores = new List<Escritor>
        {
            new EscritorBlog { Nome = "Cabo", Sobrenome = "Loso", Biografia = "Meu nome é Loso, Cabo Loso." },
            new EscritorLivro { Nome = "James", Sobrenome = "Bond", Biografia = "Meu nome é Bond, James Bond." }
        };

        // Criando a lista de Promotores
        var promotores = new List<Promotor>
        {
            new ClubeITA { Nome = "Ardiloso", Sobrenome = "Cortes", Telefone = "(31) 9 9999-6070", CartaoVisita = "Ardiloso Cortes: (31) 9 9999-6070", Local = "ITA" },
            new ClubeSESC { Nome = "Valquiria", Sobrenome = "Cain", Telefone = "(31) 9 9999-7070", CartaoVisita = "Valquiria Cain: (31) 9 9999-7070", Local = "SESC" }
        };

        // Iterando e usando os métodos dos Escritores
        foreach (var escritor in escritores)
        {
            escritor.Escrever();
            if (escritor is IVlogger vlogger)
            {
                vlogger.Vlog();
            }
            Console.WriteLine();
        }

        // Iterando e usando os métodos dos Promotores
        foreach (var promotor in promotores)
        {
            promotor.PromoverNaRedeSocial();
            promotor.PromoverAds();
            if (promotor is IBodyBuilders bodyBuilder)
            {
                bodyBuilder.Malhar();
            }
            if (promotor is IVlogger vlogger)
            {
                vlogger.Vlog();
            }
            Console.WriteLine();
        }
    }
}