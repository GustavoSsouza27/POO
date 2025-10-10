using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Digite o caminho completo do arquivo (ex: C:\\temp\\arquivo.txt): ");
        string caminho = Console.ReadLine();

        try
        {
            string conteudo = File.ReadAllText(caminho);
            Console.WriteLine("\nConteúdo do arquivo:\n");
            Console.WriteLine(conteudo);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Arquivo não encontrado! Verifique o caminho e tente novamente.");
        }
    }
}

