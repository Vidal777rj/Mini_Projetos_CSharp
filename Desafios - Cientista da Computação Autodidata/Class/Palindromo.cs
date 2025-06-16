using Kokuban;
namespace Desafios___Cientista_da_Computação_Autodidata
{
    public class Palindromo
    {
        //Compare duas palavras e verifique se ambas são palíndromos(radar, bob, anilina). A função deve retornar True ou False.
        public static bool palindromo()
        {
            Console.Write("Digite a palavra que deseja verificar se é palindromo: ");
            string palavra = Console.ReadLine();
            string invertida = new string(palavra.Reverse().ToArray());
            bool EhPalindromo = palavra.Equals(invertida, StringComparison.OrdinalIgnoreCase);


            if (EhPalindromo == true)
            {
                System.Console.WriteLine(Chalk.Red + $"A palavra: {palavra} é palindromo");
                return true;
            }
            else
            {
                System.Console.WriteLine(Chalk.Blue + $"{palavra} não é palindromo");
                return false;
            }
        }
    }
}