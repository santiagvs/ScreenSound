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

Episodio episodio1 = new Episodio(1, "O Futuro do Sei Lá", 45);
episodio1.AdicionarConvidados("Fábio Moura");
episodio1.AdicionarConvidados("Ednaldo Pereira");
episodio1.AdicionarConvidados("Casimiro");
Console.WriteLine(episodio1.Resumo);

Episodio episodio2 = new Episodio(2, "Sus", 60);
episodio2.AdicionarConvidados("André Silva");
episodio2.AdicionarConvidados("Seu Madruga");
episodio2.AdicionarConvidados("Sei lá mlk");
Console.WriteLine(episodio2.Resumo);
