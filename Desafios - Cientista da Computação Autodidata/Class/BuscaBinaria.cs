
namespace Desafios___Cientista_da_Computação_Autodidata.Class
{
    public class BuscaBinaria
    {
        /* 
        Dada uma lista de palavras em ordem alfabética, escreva uma função que execute 
        a busca binária de uma palavra e retorne se ela está ou não na lista.
        */
        public static bool ExecutarBuscaBinaria()
        {
            List<string> lista = new List<string>
            {
                 "Vasco", "Flamengo", "Botafogo", "Fluminense", "Corinthias", "Palmeiras", 
                 "Santos", "São Paulo", "Cruzeiro", "Atletico Mineiro"
            };
            lista.Sort();
            string stringDeBuscar = "Vasco";
            bool encontrado = buscaBinaria(lista, stringDeBuscar);
            if (encontrado)
            {
                System.Console.WriteLine($"{encontrado} : Algoritmo funcionando corretamente!");
                return true;
            }
            else
            {
                Console.WriteLine("string não encontrado");
                return false;
            }
        }
        private static bool buscaBinaria(List<string> lista, string palavra)
        {
            int inicio = 0;
            int fim = lista.Count - 1;

            while (inicio <= fim)
            {
                int meio = (inicio + fim) / 2;
                int comparacao = string.Compare(palavra, lista[meio], StringComparison.OrdinalIgnoreCase);

                if (comparacao == 0)
                {
                    return true;
                }
                else if (comparacao < 0)
                {
                    fim = meio - 1;
                }
                else
                {
                    inicio = meio + 1;
                }
            }
            return false;
        }
    }
}


