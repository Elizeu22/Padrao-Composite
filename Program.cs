
using SistemaPastasArquivos;

Pasta pasta = new Pasta();
Arquivo arquivo = new Arquivo();

arquivo.Nome = @"";

try
{
    long tamanhoPasta = pasta.CalcularTamanhoPasta(arquivo.Nome);

    arquivo.Tamanho = (double)tamanhoPasta / 1024 / 1024;

    Console.WriteLine($"Tamanho pasta:{arquivo.Tamanho}");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro ao calcular tamanho da pasta:{ex.Message}");
}