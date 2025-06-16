using Kokuban;

namespace Desafios___Cientista_da_Computação_Autodidata.Class
{
    public class ImprimirValores
    {
        public static void imprimirValores()
        {
            // Crie uma função recursiva que imprima os números de 1 a 10.
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    System.Console.WriteLine(Chalk.Red + $"{i}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}