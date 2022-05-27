using System;
using AulasDio.Classes;
using AulasDio.Enums;



Console.WriteLine("Olá Recrutadores do Grupo GFT! Caso estejam analisando meu perfil, desejo que sejam BEM-VINDOS!");
Console.WriteLine("É UMA HONRA TÊ-LOS AQUI!");

SerieRepositorio repositorio = new SerieRepositorio();

string opcaoUsuario = ObterOpcaoUsuario();

while (opcaoUsuario.ToUpper() != "Y")

{
    switch (opcaoUsuario)
    {
        case "1":
            ListarSeries();
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
        case "X":
            Console.WriteLine("A | Dio-Flix Incorporation | agradece por utilizar nosso serviços!");
            Console.WriteLine("Precione |[Y]| para finalizar.");
            break;
        default:
            throw new ArgumentOutOfRangeException();
    }

    opcaoUsuario = ObterOpcaoUsuario();
}


void ListarSeries()
{
    Console.WriteLine("Listar séries");

    var lista = repositorio.Lista();

    if (lista.Count == 0)
    {
        Console.WriteLine("Nenhuma série cadastrada.");
        return;
    }

    foreach (var serie in lista)
    {


        Console.WriteLine(serie.retornaTitulo());
    }
}

void InserirSerie()
{
    Console.WriteLine("Inserir nova série");

   
    foreach (int i in Enum.GetValues(typeof(Genero)))
    {
        Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
    }
    Console.Write("Digite o gênero entre as opções acima: ");
    int entradaGenero = int.Parse(Console.ReadLine());

    Console.Write("Digite o Título da Série: ");
    string entradaTitulo = Console.ReadLine();

    Console.Write("Digite o Ano de Início da Série: ");
    int entradaAno = int.Parse(Console.ReadLine());

    Console.Write("Digite a Descrição da Série: ");
    string entradaDescricao = Console.ReadLine();

    Series novaSerie = new Series(id: repositorio.ProximoId(),
                                genero: (Genero)entradaGenero,
                                titulo: entradaTitulo,
                                ano: entradaAno,
                                descricao: entradaDescricao);

    repositorio.Insere(novaSerie);
}

void AtualizarSerie()
{
    Console.Write("Digite o id da série: ");
    int indiceSerie = int.Parse(Console.ReadLine());

    
    foreach (int i in Enum.GetValues(typeof(Genero)))
    {
        Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
    }
    Console.Write("Digite o gênero entre as opções acima: ");
    int entradaGenero = int.Parse(Console.ReadLine());

    Console.Write("Digite o Título da Série: ");
    string entradaTitulo = Console.ReadLine();

    Console.Write("Digite o Ano de Início da Série: ");
    int entradaAno = int.Parse(Console.ReadLine());

    Console.Write("Digite a Descrição da Série: ");
    string entradaDescricao = Console.ReadLine();

    Series atualizaSerie = new Series(id: indiceSerie,
                                genero: (Genero)entradaGenero,
                                titulo: entradaTitulo,
                                ano: entradaAno,
                                descricao: entradaDescricao);

    repositorio.Atualiza(indiceSerie, atualizaSerie);
}


void ExcluirSerie()
{
    Console.Write("Digite o id da série: ");
    int indiceSerie = int.Parse(Console.ReadLine());

    repositorio.Exclui(indiceSerie);
}

void VisualizarSerie()
{
    Console.Write("Digite o id da série: ");
    int indiceSerie = int.Parse(Console.ReadLine());

    var serie = repositorio.RetornaPorId(indiceSerie);

    Console.WriteLine(serie);
}

//**********************************************************************************************************************************************


string ObterOpcaoUsuario()
{



    Console.WriteLine();
    Console.WriteLine("DIO Series a seu dispor!!!");
    Console.WriteLine("Informe a opção desejada: ");

    Console.WriteLine("[ 1 ] Listar Series");
    Console.WriteLine("[ 2 ] Inserir Nova Serie");
    Console.WriteLine("[ 3 ] Atualizar Serie");
    Console.WriteLine("[ 4 ] Excluir Serie");
    Console.WriteLine("[ 5 ] Visualizar Serie");
    Console.WriteLine("[ C ] Limpar Tela");
    Console.WriteLine("[ X ] Sair");

    var opcaoUsuario = Console.ReadLine().ToUpper();
    Console.WriteLine();
    return opcaoUsuario;

    Console.WriteLine("A | Dio-Flix Incorporation | agradece por utilizar nosso serviços!");
    Console.WriteLine("Precione |[ENTER]| para finalizar.");
}
