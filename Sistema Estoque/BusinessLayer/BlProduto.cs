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

            if (!String.IsNullOrEmpty(objProduto.NomeProduto) &&
                !String.IsNullOrEmpty(objProduto.Preco.ToString())  &&
                !String.IsNullOrEmpty(objProduto.Quantidade.ToString())  &&
                !String.IsNullOrEmpty(objProduto.CodBarras) &&
                !String.IsNullOrEmpty(objProduto.CodProduto) &&
                !String.IsNullOrEmpty(objProduto.DataValidade.ToString()) &&
                !String.IsNullOrEmpty(objProduto.LocalArmazenamento) &&
                !String.IsNullOrEmpty(objProduto.Descricao))
            {


                return true;

            }

            return false;
        }
    }
}
