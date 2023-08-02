class Banda
{
  public string Nome { get; }
  private List<Album> albuns = new List<Album>();

  public Banda(string nome)
  {
    Nome = nome;
  }

  public void AdicionarAlbum(Album album)
  {
    albuns.Add(album);
  }

  public void ExibirDiscografia()
  {
    Console.WriteLine($"Discografia da banda {Nome}");
    foreach (Album album in albuns)
    {
      Console.WriteLine($"- {album.Nome} ({album.DuracaoTotal} segundos)");
    }
  }
}
