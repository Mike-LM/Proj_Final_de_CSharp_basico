using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploWebAPI.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Quantidade { get; set; }

        public string Preco { get; set; }
        public Produto( string texto, string quantidade, string preco)
        {
            this.Nome = texto;
            this.Quantidade = quantidade;
            this.Preco = preco;
        }
    }
}
