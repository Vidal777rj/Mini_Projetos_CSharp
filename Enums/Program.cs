using Enums.enums;
using Enums.Models;

var Livros = new List<Book>
{
  new Book("Harry Potter e as reliquias da morte", Genre.Fantasia, 2007),
  new Book("Fundação", Genre.FicçãoCientifica, 1951),
  new Book("Em nome de Roma", Genre.Historia, 2016),
  new Book("BTK", Genre.Crimes, 2019),
};


foreach(var livro in Livros)
{
  System.Console.WriteLine($"Titulo: {livro.Titulo} | Genero: {livro.Genero} | Ano: {livro.AnoDePublicacao}");
}


Console.WriteLine("---Busca por Genero---");
foreach(var livro in Livros.FindAll(b => b.Genero == Genre.Crimes))
{
  System.Console.WriteLine(livro);
}