namespace Desafios___Cientista_da_Computação_Autodidata
{
    public class Palindromo
    {
        //Compare duas palavras e verifique se ambas são palíndromos. A função deve retornar True ou False.
        public static bool palindromo(string palavra)
        {
            string invertida = new string(palavra.Reverse().ToArray());
            bool EhPalindromo = palavra.Equals(invertida, StringComparison.OrdinalIgnoreCase);


            if (EhPalindromo == true)
            {
                System.Console.WriteLine($"A palavra: {palavra} é palindromo");
                return true;
            }
            else
            {
                System.Console.WriteLine($"{palavra} não é palindromo");
                return false;
            }
        }
    }
}