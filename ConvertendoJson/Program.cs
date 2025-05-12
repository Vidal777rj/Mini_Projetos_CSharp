/*Converter o arquivo JSON em uma lista e exibir no console*/


using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ConvertendoJson.Models;

string caminhoArquivo = "nomes.json";
ExibirDados(caminhoArquivo);
ExbirPorIdade(caminhoArquivo);
static void ExibirDados(string caminhoArquivo)
{
    try
    {
        var json = File.ReadAllText(caminhoArquivo);
        List<Pessoa> dadosJson = JsonSerializer.Deserialize<List<Pessoa>>(json);
        string jsonFormatado = JsonSerializer.Serialize(dadosJson, new JsonSerializerOptions { WriteIndented = true });
        System.Console.WriteLine(jsonFormatado);

    }
    catch (Exception ex)
    {
        System.Console.WriteLine($"Erro ao converter dados: {ex.Message}");
    }
}

static void ExbirPorIdade(string caminhoArquivo)
{
    try
    {
        var json = File.ReadAllText(caminhoArquivo);
        List<Pessoa> nomes = JsonSerializer.Deserialize<List<Pessoa>>(json);

        var filtrarPorIdade = nomes.Where(p => p.Idade > 30).ToList();

        foreach (var pessoa in filtrarPorIdade)
        {
            System.Console.WriteLine($"{pessoa.Nome} - {pessoa.Idade}");
        }

    }
    catch (Exception ex)
    {
        System.Console.WriteLine($"Erro ao converter dados: {ex.Message}");
    }
}