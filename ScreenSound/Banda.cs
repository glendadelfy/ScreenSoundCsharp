class banda
{   
    private List<Album> albums = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;

    }

    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(Album);
    }
    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbums:{album.Nome}({album.DuracaoTotal})");
        }
    }
}