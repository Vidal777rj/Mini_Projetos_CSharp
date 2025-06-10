using Desafios___Cientista_da_Computação_Autodidata;
using Desafios___Cientista_da_Computação_Autodidata.Class;
/*
Realizar os desafios propostos no livro Cientista da Computação Autodidata. Embora os exemplos estejam em Python, 
executarei as soluções em C#
*/
bool continuar = true;
while (continuar)
{
    System.Console.WriteLine("Escolha o desafio que deseja ver o resultado: ");
    System.Console.WriteLine("1 - Impressão de Valores: Crie uma função recursiva que imprima os números de 1 a 10 ");
    System.Console.WriteLine("2 - Algoritmo de busca binaria: Busca binária em uma lista de palavras ");
    System.Console.WriteLine("3 - Filtrar uma lista: Compreensão de lista: filtrar palavras com mais de 4 caracteres");
    System.Console.WriteLine("4 - Verificar Palindromo: Compare duas palavras e verifique se ambas são palíndromos. A função deve retornar True ou False ");
    System.Console.WriteLine("5 - Sair");

    string opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            ImprimirValores.imprimirValores();
            continuar = false;
            break;
        case "2":
            BuscaBinaria.ExecutarBuscaBinaria();
            continuar = false;
            break;
        case "3":
            NovaLista.novaLista();
            continuar = false;
            break;
        case "4":
            Palindromo.palindromo("radar");
            continuar = false;
            break;
        case "5":
            continuar = false;
            break;
        default:
            System.Console.WriteLine("Opção inválida");
            Console.ReadKey();
            break;
    }
}
