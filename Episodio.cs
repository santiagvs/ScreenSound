class Episodio
{
  public static int numeroEpisodios { get; private set; } = 1;
  public int Numero { get; set; }
  public int Duracao { get; set; }
  public int Ordem { get; }
  public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";
  public string? Titulo { get; }
  public List<string> convidados = new List<string>();

  public Episodio(int ordem, string titulo, int duracao)
  {
    Numero = numeroEpisodios;
    Duracao = duracao;
    numeroEpisodios++;
    Ordem = ordem;
    Titulo = titulo;
  }

  public void AdicionarConvidados(string convidado)
  {
    convidados.Add(convidado);
  }

}
