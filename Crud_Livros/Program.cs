using Crud_Livros;
using System.Text.Json;

List<Livros> livros = new List<Livros>();

int proximoIdLivro = 1;

bool executando = true;

while (executando)
{
    System.Console.WriteLine("1 - Adicionar: ");
    System.Console.WriteLine("2 - Listar: ");
    System.Console.WriteLine("3 - Remover: ");
    System.Console.WriteLine("4 - Editar: ");
    System.Console.WriteLine("5 - SAIR: ");
    System.Console.WriteLine("6 - Salvar: ");

    try
    {
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                AdicionarLivro();
                break;
            case 2:
                ListarLivro();
                break;
            case 3:
                RemoverLivro();
                break;
            case 4:
                EditarLivro();
                break;
            case 5:
                executando = false;
                break;
            case 6:
                SalvarEmJSON();
                break;
            default:
                System.Console.WriteLine("Opção invalida");
                break;
        }
    }
    catch (FormatException)
    {
        System.Console.WriteLine("Digite um valor valido, correspondente ao anunciado.");
    }
    catch (Exception ex)
    {
        System.Console.WriteLine(ex.Message);
    }
}

void AdicionarLivro()
{
    Console.Write("Digite o nome do livro: ");
    string titulo = Console.ReadLine();

    Console.Write("Digite o autor do livro: ");
    string autor = Console.ReadLine();

    var livro = new Livros { Id = proximoIdLivro++, Titulo = titulo, Autor = autor };

    livros.Add(livro);
    System.Console.WriteLine("Livro adicionado com sucesso!");
}


void ListarLivro()
{
    if (livros.Count == 0)
    {
        System.Console.WriteLine("Nenhum livro a ser listado");
        return;
    }

    foreach (var livro in livros)
    {
        System.Console.WriteLine($"ID: {livro.Id} | Nome Livro: {livro.Titulo} | Autor: {livro.Autor}");
    }
}

void EditarLivro()
{
    try
    {
        System.Console.Write("Digite o ID do livro que deseja atualizar: ");
        int id = int.Parse(Console.ReadLine());

        var livro = livros.FirstOrDefault(l => l.Id == id);
        if (livro == null)
        {
            System.Console.WriteLine("Livro não encontrado");
            return;
        }

        Console.Write("Novo titulo: ");
        livro.Titulo = Console.ReadLine();

        Console.Write("Novo autor: ");
        livro.Autor = Console.ReadLine();

        System.Console.WriteLine("Livro atualizado com sucesso");

        ListarLivro();
    }
    catch (FormatException)
    {
        System.Console.WriteLine("ID invalido");
        return;
    }
}

void RemoverLivro()
{
    try
    {
        System.Console.Write("Digite o ID do livro que deseja remover: ");
        int id = int.Parse(System.Console.ReadLine());

        var livro = livros.FirstOrDefault(l => l.Id == id);

        if (livro == null)
        {
            System.Console.WriteLine("ID do livro inválido");
            return;
        }

        livros.Remove(livro);
        System.Console.WriteLine("Livro removido com sucesso");
        ListarLivro();
    }
    catch (FormatException)
    {
        System.Console.WriteLine("ID invalido!");
    }
}

void SalvarEmJSON()
{
    string json = JsonSerializer.Serialize(livros, new JsonSerializerOptions { WriteIndented = true });
    File.WriteAllText("livros.json", json);

    System.Console.WriteLine("Livro salvo com sucesso!");
}
