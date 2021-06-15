using System;
using System.IO;

namespace Etapa8_StreamReaderWriterExemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\Infnet\Curso C#\Etapa8\Texto.txt";

            if (File.Exists(path))
                File.Delete(path);

            //ESCRITA
            using StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("Meu primeiro texto");
            sw.WriteLine("Meu segundo texto");
            sw.WriteLine("Meu terceiro texto");

            //LEITURA
            using (StreamReader sr = new StreamReader(path))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
        }
    }
}
