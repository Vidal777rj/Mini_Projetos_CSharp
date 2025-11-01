using Enums.enums;

namespace Enums.Models
{
    public class Book
    {
        public string Titulo { get; set; }
        public Genre Genero { get; set; }
        public int AnoDePublicacao { get; set; }

        public Book(string titulo, Genre genero, int anoDePublicacao)
        {
            Titulo = titulo;
            Genero = genero;
            AnoDePublicacao = anoDePublicacao;
        }

    public override string ToString()
    {
            return $"Titulo - {Titulo}";
    }
    }
}