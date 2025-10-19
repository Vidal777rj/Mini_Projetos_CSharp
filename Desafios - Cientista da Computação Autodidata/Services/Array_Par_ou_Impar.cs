using Kokuban;
namespace Desafios___Cientista_da_Computação_Autodidata.Class
{
    public static class Array_Par_ou_Impar
    {
        /* 
        Dado um array chamado an_array de números inteiros não negativos, retorne um array composto de todos os elementos
        pares seguido de todos os elementos impares de an_array
       */
        private static readonly List<int> an_array = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        public static void ExecutarBusca()
        {
            List<int> resultado = ExecutarBuscaParOuImpar();
            foreach (int valoresDosArrays in resultado)
            {
                System.Console.WriteLine(Chalk.Red + $"Pares depois Impares: " + Chalk.White + valoresDosArrays);
                System.Console.Write("");
            }
        }

        private static List<int> ExecutarBuscaParOuImpar()
        {
            List<int> valoresPares = new List<int>();
            List<int> valoresImpares = new List<int>();

            foreach (int valoresArray in an_array)
            {
                if (valoresArray % 2 == 0)
                    valoresPares.Add(valoresArray);
                else
                    valoresImpares.Add(valoresArray);
            }
            List<int> Resultado = new List<int>();
            Resultado.AddRange(valoresPares);
            Resultado.AddRange(valoresImpares);
            return Resultado;
        }
    }
}
