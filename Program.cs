    

try
{
string[] linhas = File.ReadAllLines("Arquivos/pasta/arquivo_Leitura.txt");

foreach (string line in linhas){
    Console.WriteLine(line);
}
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu uma Exceção. Pasta não enontrada.");
}
catch(FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu uma Exceção. Arquivo não encontrado.");
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma Exceção: {ex.Message}");
}
finally
{
    Console.WriteLine("Chegou até aqui.");
}