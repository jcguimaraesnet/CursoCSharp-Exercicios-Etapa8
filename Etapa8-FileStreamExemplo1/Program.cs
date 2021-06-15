using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Etapa8_FileStreamExemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\Infnet\Curso C#\Etapa8\Texto.txt";

            if (File.Exists(path))
                File.Delete(path);

            //ESCRITA
            using (FileStream fsEscrita = File.Create(path))
            {
                AdicionarTextoAsync(fsEscrita, "Meu primeiro texto\n");
                AdicionarTextoAsync(fsEscrita, "Meu segundo texto\n");
                AdicionarTextoAsync(fsEscrita, "Meu terceiro texto\n");
            }

            //LEITURA
            using FileStream fsLeitura = File.OpenRead(path);
            byte[] info = new byte[10];
            UTF8Encoding encoding = new UTF8Encoding();
            while (fsLeitura.Read(info, 0, info.Length) > 0)
            {
                Console.Write(encoding.GetString(info));
            }
        }

        private static async void AdicionarTextoAsync(FileStream fs, string texto)
        {
            byte[] info = new UTF8Encoding().GetBytes(texto);
            await fs.WriteAsync(info, 0, info.Length);
        }
    }
}
