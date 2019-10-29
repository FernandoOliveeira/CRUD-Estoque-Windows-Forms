using Sistema_Estoque.DataLayer;
using Sistema_Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Estoque.BusinessLayer
{
    class BlProduto : DlProduto
    {
        public bool VerificarDadosProduto(Produto objProduto)
        {
            bool cadastrar = false;

            if (String.IsNullOrEmpty(objProduto.NomeProduto) &&
                objProduto.Preco != 0 &&
                objProduto.Quantidade != 0 &&
                String.IsNullOrEmpty(objProduto.CodBarras) &&
                String.IsNullOrEmpty(objProduto.DataValidade.ToString()) &&
                String.IsNullOrEmpty(objProduto.LocalArmazenamento) &&
                String.IsNullOrEmpty(objProduto.Descricao))
            {

                cadastrar = true;

                return cadastrar;

            }

            return cadastrar;
        }
    }
}
