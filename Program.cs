using CadastroDeSeries;

internal class Program
{
    static SerieRepositorio repositorio = new SerieRepositorio();
    private static void Main(string[] args)
    {
        string opcaoUsuario = ObterOpcaoUruário();

        while (opcaoUsuario.ToUpper() != "X")
        {
            switch (opcaoUsuario)
            {
                case "1":
                    ListarSerie();
                    break;
                case "2":
                    InserirSerie();
                    break;
                case "3":
                    AtualizarSerie();
                    break;
                case "4":
                    ExcluirSerie();
                    break;
                case "5":
                    VisualizarSerie();
                    break;
                case "C":
                    Console.Clear();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            opcaoUsuario = ObterOpcaoUruário();
        }

        Console.WriteLine("Obrigado por utilizar nossos serviços.");
        Console.ReadLine();
    }

    private static void ListarSerie()
    {
        System.Console.WriteLine("Listar Séries");

        var lista = repositorio.Listar();

        if (lista.Count == 0)
        {
            Console.WriteLine("Nenhuma série cadastrada!");
            return;
        }

        foreach (var serie in lista)
        {
            var excluido = serie.RetornaExcluido();

            System.Console.Write("#ID {0}: - {1} - {2}", serie.RetornaId(), serie.RetornaTitulo(), excluido ? "*Excluído*" : "");
            // Aqui poderia ser utilizada interpolação de string, porém acho que fica mais legível assim, quando chamamos métodos.
            // Se fosse para chamar os valores contidos em variáveis, acredito que a interpolação seria mais correta, ou pelo menos, mais agradável aos olhos.
        }
    }

    private static void ExcluirSerie()
    {
        Console.Write("Digite o id da série: ");
        int indiceSerie = int.Parse(Console.ReadLine()!);

        repositorio.Exclui(indiceSerie);
    }

    private static void InserirSerie()
    {
        System.Console.WriteLine("Inserir Nova Série\n");

        Serie novaSerie = PreencherDadosSerie(repositorio.ProximoId());

        repositorio.Insere(novaSerie);
    }

    private static void AtualizarSerie()
    {
        Console.Write("Digite o id da série: ");
        int indiceSerie = int.Parse(Console.ReadLine()!);

        Serie atualizaSerie = PreencherDadosSerie(indiceSerie);
        repositorio.Atualiza(indiceSerie, atualizaSerie);
    }

    private static void VisualizarSerie()
    {
        Console.Write("Digite o id da série: ");
        int indiceSerie = int.Parse(Console.ReadLine()!);

        var serire = repositorio.RetornaPorId(indiceSerie);

        System.Console.WriteLine(serire);
    }

    private static string ObterOpcaoUruário()
    {
        Console.WriteLine();
        Console.WriteLine("Séries a seu dispor!!");
        Console.WriteLine("Informe a opção desejada:\n");

        Console.WriteLine("1 - Listar Séries");
        Console.WriteLine("2 - Inserir nova Série");
        Console.WriteLine("3 - Atualizar Série");
        Console.WriteLine("4 - Excluir série");
        Console.WriteLine("5 - Visualizar série");
        Console.WriteLine("C - Limpar Tela");
        Console.WriteLine("X - Sair");
        Console.WriteLine();

        string opcaoUsuario = Console.ReadLine()!.ToUpper();
        Console.WriteLine();
        return opcaoUsuario;
    }

    static Serie PreencherDadosSerie(int valor)
    {
        int id = valor;

        // Método Enum.GetValues: Recupera uma matriz dos valores das constantes em uma enumeração informada como parâmetro.
        // Método Enum.GetName: Recupera o nome da constante na enumeração objeto que tem o valor informado.
        foreach (int i in Enum.GetValues(typeof(Genero)))
        {
            System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
        }

        System.Console.Write("Digite o genero entre as opções acima: ");
        int entradaGenero = int.Parse(Console.ReadLine()!);

        System.Console.Write("Digite o Título da Série: ");
        string entradaTitulo = Console.ReadLine()!;

        Console.Write("Digite o Ano de Início da Série: ");
        int entradaAno = int.Parse(Console.ReadLine()!);

        Console.Write("Digite a Descrição da Série: ");
        string entradaDescricao = Console.ReadLine()!;

        return new Serie(id: id,
                         genero: (Genero)entradaGenero,
                         titulo: entradaTitulo,
                         ano: entradaAno,
                         descricao: entradaDescricao);

    }
}