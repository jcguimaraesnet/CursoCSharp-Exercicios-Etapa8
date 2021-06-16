using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Etapa8_FileApendWriteAllLinesExemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Infnet\Curso C#\1T-2021\CursoCSharp-Exercicios-Etapa8\Texto.txt";

            if (File.Exists(path))
                File.Delete(path);

            //ESCRITA
            string[] textoListaEscrita = { 
                "Meu primeiro texto",
                "Meu segundo texto",
                "Meu terceiro texto"
            };
            //File.WriteAllLines(path, textoListaEscrita);

            //LEITURA
            //string[] textoListaLeitura = File.ReadAllLines(path);
            //foreach (string texto in textoListaLeitura)
            //    Console.WriteLine(texto);


            var listaAmigos = new List<Amigo>()
            {
                new Amigo("Pablo", 1),
                new Amigo("Pedro", 5),
                new Amigo("Mariana", 2)
            };
            var colecaoDeNomesString = listaAmigos.Select(x => x.ToString());
            File.WriteAllLines(path, colecaoDeNomesString);

        }


    }
}
