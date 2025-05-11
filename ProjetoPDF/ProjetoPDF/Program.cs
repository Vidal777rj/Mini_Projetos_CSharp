using System.Net.Mime;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

QuestPDF.Settings.License = LicenseType.Community;

string CaminhoArquivo = "exemplo2.pdf";


Console.Write("Digite o conteúdo para gravar no PDF: ");
string conteudo = Console.ReadLine();

var document = Document.Create(container =>
{
    container.Page(page =>
    {
        page.Size(PageSizes.A4);
        page.Margin(50);
        page.PageColor(Colors.White);
        page.DefaultTextStyle(x => x.FontSize(30));

        page.Content()
            .Text(conteudo);
    });
});

try
{
    // Geração do PDF
    document.GeneratePdf(CaminhoArquivo);
    Console.WriteLine($"✅ PDF gerado com sucesso! Caminho: {Environment.CurrentDirectory}\\{CaminhoArquivo}");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro ao gerar o PDF: {ex.Message}");
}


