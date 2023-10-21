class Podcast
{
    private List<Episodio> episodioList = new();

    public Podcast( string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }

    public string Nome { get; }

    public int TotalEpisodios => episodioList.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodioList.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Host: {Nome} \nNome: {Host}\n");
        foreach (Episodio ep in episodioList.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(ep.Resumo);
        }
        Console.WriteLine($"\nTotal de Episodios: {TotalEpisodios}");
    }
}