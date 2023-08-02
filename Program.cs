// Banda queen = new Banda("Queen");

// Album albumDoQueen = new Album("A Night At The Opera");

// Musica musica1 = new Musica(queen, "Love Of My Life")
// {
//   Duracao = 213,
//   Disponivel = true,
// };

// Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
// {
//   Duracao = 354,
//   Disponivel = false,
// };

// albumDoQueen.AdicionarMusica(musica1);
// albumDoQueen.AdicionarMusica(musica2);
// queen.AdicionarAlbum(albumDoQueen);

// musica1.ExibirFichaTecnica();
// musica2.ExibirFichaTecnica();

// albumDoQueen.ExibirMusicasDoAlbum();
// queen.ExibirDiscografia();

Episodio episodio1 = new Episodio(6, "O Futuro do Sei Lá", 45);
episodio1.AdicionarConvidados("Fábio Moura");
episodio1.AdicionarConvidados("Ednaldo Pereira");
episodio1.AdicionarConvidados("Casimiro");

Episodio episodio2 = new Episodio(3, "Sus", 60);
episodio2.AdicionarConvidados("André Silva");
episodio2.AdicionarConvidados("Seu Madruga");

Podcast podcast = new("Podcast Especial", "Daniel");
podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);
podcast.ExibirDetalhes();
