using Desafios___Cientista_da_Computação_Autodidata;
using Desafios___Cientista_da_Computação_Autodidata.Class;
using Kokuban;
/*
Realizar os desafios propostos no livro Cientista da Computação Autodidata. Embora os exemplos estejam em Python, 
executarei as soluções em C#
*/
bool continuar = true;
while (continuar)
{
    System.Console.WriteLine(Chalk.Underline.BgGrey + "------------------------------------------------------------------------------");
    System.Console.WriteLine(Chalk.Cyan + "Escolha o desafio que deseja ver o resultado: ");
    System.Console.WriteLine(Chalk.Blue + "1 - Impressão de Valores: Crie uma função recursiva que imprima os números de 1 a 10 ");
    System.Console.WriteLine(Chalk.Blue + "2 - Algoritmo de busca binaria: Busca binária em uma lista de palavras ");
    System.Console.WriteLine(Chalk.Blue + "3 - Filtrar uma lista: Compreensão de lista: filtrar palavras com mais de 4 caracteres");
    System.Console.WriteLine(Chalk.Blue + "4 - Verificar Palindromo: Compare duas palavras e verifique se ambas são palíndromos. A função deve retornar True ou False ");
    System.Console.WriteLine(Chalk.Blue + "5 - Retorne um array composto de todos os elementos, pares seguido de todos os elementos impares de an_array ");
    System.Console.WriteLine(Chalk.Red + "6 - Sair");
    System.Console.WriteLine(Chalk.Underline.BgGrey + "------------------------------------------------------------------------------");

    string opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            ImprimirValores.imprimirValores();
            break;
        case "2":
            BuscaBinaria.ExecutarBuscaBinaria();
            break;
        case "3":
            NovaLista.novaLista();
            break;
        case "4":
            Palindromo.palindromo();
            break;
        case "5":
            Array_Par_ou_Impar.ExecutarBusca();
            break;
        case "6":
            Console.WriteLine("Encerrando Programa...");
            Thread.Sleep(2000);
            Console.WriteLine("Tchau!");
            continuar = false;
            break;
        default:
            System.Console.WriteLine("Opção inválida");
            Console.ReadKey();
            break;
    }
}
