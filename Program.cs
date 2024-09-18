    

string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

foreach (string line in linhas){
    Console.WriteLine(line);
}