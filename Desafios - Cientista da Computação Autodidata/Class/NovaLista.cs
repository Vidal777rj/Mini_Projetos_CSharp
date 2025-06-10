namespace Desafios___Cientista_da_Computação_Autodidata
{
    public class NovaLista
    {
        /*
        Utilize compreensão de lista (list comprehension) para retornar uma nova lista com todas as palavras da relação a seguir que 
        tenham mais de quatro caracteres:
        ["selftaught", "code", "sit", "eat", "programming", "dinner", "one", "two", "coding", "a", "tech"]
        */
        public static void novaLista()
        {
            List<string> stringInformadasNoLivro = new List<string>
            {
                "selftaught", "code", "sit", "eat", "programming", "dinner", "one", "two", "coding", "a", "tech"
            };

            List<string> resultado = stringInformadasNoLivro.Where(l => l.Length > 4).ToList();
            foreach (string str in resultado)
            {
                System.Console.WriteLine(str);
            }
        }
    }
}