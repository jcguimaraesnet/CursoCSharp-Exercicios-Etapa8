using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Etapa8_LeituraEscritaComArquivoDeConfiguracao
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly string sourceFile;

        public Worker(ILogger<Worker> logger, IConfiguration configuration)
        {
            _logger = logger;
            sourceFile = configuration.GetValue<string>("AppSettings:sourceFile");
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            if (File.Exists(sourceFile))
                File.Delete(sourceFile);

            //ESCRITA
            string[] textoListaEscrita = {
                "Meu primeiro texto",
                "Meu segundo texto",
                "Meu terceiro texto"
            };
            File.WriteAllLines(sourceFile, textoListaEscrita);

            //LEITURA
            string[] textoListaLeitura = File.ReadAllLines(sourceFile);
            foreach (string texto in textoListaLeitura)
                Console.WriteLine(texto);

        }
    }
}
