using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Estoque.Model
{
    class Produto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public string CodBarras { get; set; }
        public DateTime DataValidade { get; set; }
        public string LocalArmazenamento { get; set; }
        public string Descricao { get; set; }

    }
}
