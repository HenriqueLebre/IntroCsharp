class Filme
{

    public string nome;
    public string diretor;
    public int duracaoFilme;
    public bool Premium;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"diretor: {diretor}");
        Console.WriteLine($"duracaoFilme: {duracaoFilme}");
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
