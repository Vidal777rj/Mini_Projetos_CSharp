using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

List<string> tarefa = new List<string>();
int opcao;
bool executando = true;
while (executando)
{
    Console.WriteLine("Escolha as opções a seguir");
    Console.WriteLine("1 - Adicionar tarefa");
    Console.WriteLine("2 - Remover tarefa");
    Console.WriteLine("3 - Visualizar tarefas");
    Console.WriteLine("4 - Encerrar programa");

    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        System.Console.WriteLine("Digite um número valido");
        continue;
    }

    switch (opcao)
    {
        case 1:
            AdicionarTarefa();
            break;
        case 2:
            RemoverTarefa();
            break;
        case 3:
            VisualizarTarefas();
            break;
        case 4:
            System.Console.WriteLine("Encerrando o Programa, bye bye");
            executando = false;
            break;
        default:
            Console.WriteLine("Digite uma opção valida");
            break;
    }
}
void AdicionarTarefa()
{
    Console.Write("Digite a tarefa a ser adicionada: ");
    string task = Console.ReadLine();
    tarefa.Add(task);
}

void RemoverTarefa()
{
    if (tarefa.Count == 0)
    {
        System.Console.WriteLine("Nenhuma tarefa cadastrada!");
        return;
    }
    for (int i = 0; i < tarefa.Count; i++)
    {
        System.Console.WriteLine($"{i} : {tarefa[i]}");
    }
    Thread.Sleep(2000);
    System.Console.Write("Digite o número da tarefa que deseja excluir: ");
    if (int.TryParse(Console.ReadLine(), out int numeroDaTarefa))
    {
        if (numeroDaTarefa >= 0 && numeroDaTarefa < tarefa.Count)
        {
            tarefa.RemoveAt(numeroDaTarefa);
            System.Console.WriteLine("Tarefa excluido com sucesso");
        }
        else
        {
            System.Console.WriteLine("Numero intervalo invalido");
        }
    }
    else
    {
        System.Console.WriteLine("Número da tarefa invalido");
    }

}
void VisualizarTarefas()
{
    System.Console.WriteLine("Tarefas cadastradas");
    Thread.Sleep(2000);
    foreach (var tarefa in tarefa)
    {
        System.Console.WriteLine(tarefa);
    }
}