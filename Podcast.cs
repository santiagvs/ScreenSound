class Podcast
{
  public string Host { get; }
  public string Nome { get; }
  public int TotalEpisodios { get; } = Episodio.numeroEpisodios;

  public Podcast(string host, string nome)
  {
    Host = host;
    Nome = nome;
  }

  public void ExibirDetalhes(string parameter)
  {

  }
}
