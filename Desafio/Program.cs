Episodio ep1 = new Episodio(1, "Técnicas de Administração", 45);
ep1.AdicionarConvidados("Glenda");

Episodio ep2 = new Episodio(2, "Pate-Papo Mãe e Filha", 45);
ep2.AdicionarConvidados("Glenda");
ep2.AdicionarConvidados("Isabel");

Episodio ep3 = new Episodio(3, "Pate-Papo Família", 45);
ep3.AdicionarConvidados("Glenda");
ep3.AdicionarConvidados("Isabel");
ep3.AdicionarConvidados("Juan");
ep3.AdicionarConvidados("Sebastian");
ep3.AdicionarConvidados("Fofo");
ep3.AdicionarConvidados("Timon");

Podcast podcast = new Podcast("Podcast especial", "Glenda");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);
podcast.ExibirDetalhes();