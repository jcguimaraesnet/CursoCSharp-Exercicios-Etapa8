using System;
using System.IO;

namespace Etapa8_FileApendWriteAllLinesExemplo3
{
    class Program
    {
        static async void Main(string[] args)
        {
            string path = @"E:\Infnet\Curso C#\Etapa8\Texto.txt";

            if (File.Exists(path))
                File.Delete(path);

            //ESCRITA
            string[] textoListaEscrita = { 
                "Meu primeiro texto",
                "Meu segundo texto",
                "Meu terceiro texto"
            };
            await File.WriteAllLinesAsync(path, textoListaEscrita);

            //LEITURA
            string[] textoListaLeitura = await File.ReadAllLinesAsync(path);
            foreach (string texto in textoListaLeitura)
                Console.WriteLine(texto);
        }
    }
}
