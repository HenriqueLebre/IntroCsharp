namespace IntroCsharp.Models;
internal class Filme
{

    public Filme(string diretor, string nome)
    {
        Diretor = diretor;
        Nome = nome;
    }

    public string Nome { get; }
    public string Diretor { get; }
    public int DuracaoFilme { get; set; }
    public bool Premium { get; set; }
    public string DescricaoFilme =>
        $"O Filme {Nome} foi dirigido por {Diretor}";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"diretor: {Diretor}");
        Console.WriteLine($"duracaoFilme: {DuracaoFilme}");
        if (Premium)
        {
            Console.WriteLine("Filme disponível no seu plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Premium para assistir este Filme.");
        }
    }

}
