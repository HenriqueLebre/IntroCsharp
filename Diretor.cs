class Diretor
{
    private List<AlbumDiretor> albums = new List<AlbumDiretor>();

    public Diretor(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public void AdicionarFilme(AlbumDiretor album)
    {
        albums.Add(album);
    }

    public void ExibirResumo()
    {
        Console.WriteLine($"Resumo do Diretor:  {Nome}");

        foreach (AlbumDiretor album in albums)
        {
            Console.WriteLine($"Album: {album.Nome}");
        }
    }
}