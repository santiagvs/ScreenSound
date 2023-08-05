using ScreenSound.Modelos;

Banda ira = new Banda("Ira!");
Banda beatles = new("Beatles!");

Dictionary<string, Banda> bandasRegistradas = new();

void ExibirLogo()
{
  Console.WriteLine(@"
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
  ");
  Console.WriteLine("Boas vindas ao Screen Sound");
}

void ExibirOpcoesDoMenu()
{
  ExibirLogo();
  Console.WriteLine("\nDigite 1 para registrar uma banda");
  Console.WriteLine("Digite 2 para mostrar todas as bandas");
  Console.WriteLine("Digite 3 para avaliar uma banda");
  Console.WriteLine("Digite 4 para exibir a média uma banda");
  Console.WriteLine("Digite 0 para sair");

  Console.Write("\nDigite a sua opção: ");
  string opcaoEscolhida = Console.ReadLine()!;
  int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

  switch (opcaoEscolhidaNumerica)
  {
    case 1:
      RegistrarBanda();
      break;
    case 2:
      MostrarBandas();
      break;
    case 3:
      AvaliarBanda();
      break;
    case 4:
      NotaMedia();
      break;
    case 0:
      Console.WriteLine("Tchau tchau");
      break;
    default:
      Console.WriteLine("Opção inválida");
      break;
  }
}

void RegistrarBanda()
{
  Console.Clear();
  ExibirTituloDaOpcao("Registro de bandas");

  Console.Write("Digite o nome da banda que deseja registrar: ");
  string nomeDaBanda = Console.ReadLine()!;
  bandasRegistradas.Add(nomeDaBanda, new List<int>());
  Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
  Thread.Sleep(2000);
  Console.Clear();
  ExibirOpcoesDoMenu();
}

void MostrarBandas()
{
  Console.Clear();
  ExibirTituloDaOpcao("Nomes das bandas registradas:");

  foreach (string nomeDaBanda in bandasRegistradas.Keys)
  {
    Console.WriteLine("- " + nomeDaBanda);
  }

  // Console.WriteLine("*** Versão com For ***");
  // for (int i = 0; i < listaDasBandas.Count; i++)
  // {
  //   Console.WriteLine("- {listaDasBandas[i]}");
  // }
  Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
  Console.ReadKey();
  Console.Clear();
  ExibirOpcoesDoMenu();
}

void AvaliarBanda()
{
  Console.Clear();
  ExibirTituloDaOpcao("Avaliar banda:");
  Console.Write("Digite o nome da banda que deseja avaliar: ");
  string nomeDaBanda = Console.ReadLine()!;
  if (bandasRegistradas.ContainsKey(nomeDaBanda))
  {
    Console.Write($"Que nota a banda {nomeDaBanda} merece? ");
    int nota = int.Parse(Console.ReadLine()!);
    bandasRegistradas[nomeDaBanda].Add(nota);
    Console.WriteLine($"\nA nota {nota} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
  }
  else
  {
    Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
  }
}

void NotaMedia()
{
  Console.Clear();
  ExibirTituloDaOpcao("Ver nota média da banda:");
  Console.Write("Digite o nome da banda que deseja ver a nota: ");
  string nomeDaBanda = Console.ReadLine()!;

  if (bandasRegistradas.ContainsKey(nomeDaBanda))
  {
    // List<int> notaMediaBanda = bandasRegistradas[nomeDaBanda];
    double notaMediaBanda = bandasRegistradas[nomeDaBanda].Average();
    double notaMediaArredondada = Math.Round(notaMediaBanda, 2);
    Console.WriteLine($"\nA nota média da banda {nomeDaBanda} é {notaMediaArredondada}");
    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
  }
  else
  {
    Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
  }
}

void ExibirTituloDaOpcao(string titulo)
{
  int quantidadeLetras = titulo.Length;
  string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
  Console.WriteLine(asteriscos);
  Console.WriteLine(titulo);
  Console.WriteLine(asteriscos + "\n");
}

ExibirOpcoesDoMenu();
