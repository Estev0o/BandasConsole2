//Banda queen = new Banda("Queen");

//Album albumDoQueen = new Album("A night at the opera");

//Musica musica1 = new Musica(queen, "Love of my life")
//{
//    Duracao = 213,
//    Disponivel = true,
//};

//Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
//{
//    Duracao = 354,
//    Disponivel = false,
//};

//albumDoQueen.AdicionarMusica(musica1);
//albumDoQueen.AdicionarMusica(musica2);
//queen.AdicionarAlbum(albumDoQueen);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//albumDoQueen.ExibirMusicasDoAlbum();
//queen.ExibirDiscografia();

Episodio ep1 = new (50, "Tecnica de facilitacao", 2);
ep1.AdicionarConvidados("MARIA");
ep1.AdicionarConvidados("PAULO");
ep1.AdicionarConvidados("Gabriel");


Episodio ep2 = new(90, "Tecnica de Aprendizado", 1);
ep2.AdicionarConvidados("Gustavo");
ep2.AdicionarConvidados("Marcia");
ep2.AdicionarConvidados("Valeria");

Podcast podcast = new("Podcast flufluy", "Victor");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();