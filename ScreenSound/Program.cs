Banda BTS = new BTS("BTS");
// BTS.Nome = "Jimin";

Album albumDoJungkook = new Album("Golden");
// albumDoJungkook.Nome = "Golden";

Musica musica1 = new Musica(BTS,  "Somebody")
{
    Duracao = 400,
    Disponivel = true,
};
// musica1.Nome = "Somebody";
// musica.Duracao = 400;
// musica1.Disponivel = true;

// musica1.Artista = new Banda();

Musica musica2 = new Musica(BTS, "Please don't change")
{
    Duracao = 400,
    Disponivel = true,
};
// musica2.Nome = "Please don't change";
// musica.Duracao = 400;   

albumDoJungkook.AdicionarMusica(musica1);
albumDoJungkook.AdicionarMusica(musica2);
albumDoJungkook.ExibirMusicasDoAlbum();

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica(); 
BTS.AdicionarAlbum(albumDoJungkook);
BTS.ExibirDiscografia();




// Musica musica1 = new Musica();
// musica1.nome = "Tira me una foto";
// musica1.artista = "Mesita, Tiago Pzk, Nicki Nicole e Emilia";
// musica1.duracao = 400;
// musica1.Disponivel = true;
// // musica1.DescricaoResumida = "";
// Console.WriteLine(musica1.Disponivel);


// // Console.WriteLine($"Nome: {musica1.nome}");
// // Console.WriteLine($"Artista: {musica1.artista}");

// Musica musica2 = new Musica();
// musica2.nome = "Euphoria";
// musica2.artista = "Jungkook";
// musica2.duracao = 400;
// musica2.Disponivel = false;

// // Console.WriteLine($"Nome: {musica2.nome}");
// // Console.WriteLine($"Artista: {musica2.artista}");
// musica1.ExibirFichaTecnica();
// musica2.ExibirFichaTecnica();