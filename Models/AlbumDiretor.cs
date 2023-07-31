namespace IntroCsharp.Models;
class AlbumDiretor
{
    private List<Filme> filmes = new List<Filme>();

    public AlbumDiretor(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public string Genero { get; set; }
    public int TotalFilmes => filmes.Sum(f => f.DuracaoFilme);

    public void Adcionarfilme(Filme filme)
    {
       filmes.Add(filme);
    }

    public void ExibeFilmesDiretor()
    {
        Console.WriteLine($"Filmes do diretor: {Nome} e do gênero: {Genero}");
        foreach (Filme filme in filmes) 
        { 
            Console.WriteLine($"Filme: {filme.Nome}");
            Console.WriteLine($"Todos os filmes do diretor {Nome} somados tem duracao de: {TotalFilmes}");

        }
    }

}