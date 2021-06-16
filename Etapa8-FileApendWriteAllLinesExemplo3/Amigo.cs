using System;
using System.Collections.Generic;
using System.Text;

namespace Etapa8_FileApendWriteAllLinesExemplo3
{
    public class Amigo
    {
        public Amigo(string nome, int qtdeFilhos)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            QuantidadeFilho = qtdeFilhos;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int QuantidadeFilho { get; set; }

        public override string ToString()
        {
            return $"{Id}|{Nome}|{QuantidadeFilho}";
        }
    }
}
