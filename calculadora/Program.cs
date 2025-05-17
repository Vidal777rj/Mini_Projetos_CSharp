using calculadora.Services;
using calculadora.Services.Operacoes;
using Kokuban;

//Criar calculadora com adição, subtração, divisão e multiplicação utilizando classe abstrata para resolução matematica.  

var calculadora = new CalculadoraService();

while (true)
{
    System.Console.WriteLine("=== CALCULADORA ===");
    System.Console.WriteLine("Escolha a operação matematica");

    System.Console.WriteLine("1 - Adição");
    System.Console.WriteLine("2 - Subtração");
    System.Console.WriteLine("3 - Multiplicação");
    System.Console.WriteLine("4 - Divisão");
    System.Console.WriteLine("0 - Sair");

    Console.Write($"Opção: ");

    string escolha = Console.ReadLine();

    if (escolha == "0")
    {
        break;
    }

    try
    {
        IOperacao operacao = escolha switch
        {
            "1" => new Adicao(),
            "2" => new Subtracao(),
            "3" => new Multiplicacao(),
            "4" => new Divisao(),
            _ => throw new InvalidOperationException(Chalk.Red + "Opção inválida"),
        };
        Console.Write("Digite os números separados com espaço: ");
        string[] entradas = Console.ReadLine().Split(' ');
        double[] numeros = Array.ConvertAll(entradas, double.Parse);

        double resultado = calculadora.Calcular(operacao, numeros);

        Console.WriteLine(Chalk.BgBrightBlue + $"Resultado: {resultado} ");
    }
    catch (Exception ex)
    {
        System.Console.WriteLine($"Erro no calculo: {ex.Message}");
    }
    System.Console.WriteLine(Chalk.Yellow + "Calculadora encerrado");
}