using Sistema_Estoque.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Estoque.DataLayer
{
    class DlProduto : Connection
    {
        public bool CadastrarProduto(Produto produto)
        {
            string querystr = "INSERT INTO PRODUTOS VALUES(@nomeProduto, @preco, @quantidade, @codBarras, @dataValidade, @localArmazenado, @descricao)";

            SqlCommand command = new SqlCommand(querystr, AbrirBanco());
            command.Parameters.AddWithValue("@nomeProduto", produto.NomeProduto);
            command.Parameters.AddWithValue("@preco", produto.Preco);
            command.Parameters.AddWithValue("@quantidade", produto.Quantidade);
            command.Parameters.AddWithValue("@codBarras", produto.CodBarras);
            command.Parameters.AddWithValue("@dataValidade", produto.DataValidade);
            command.Parameters.AddWithValue("@localArmazenado", produto.LocalArmazenamento);
            command.Parameters.AddWithValue("@descricao", produto.Descricao);

            uint res = (uint)command.ExecuteNonQuery();

            if (res != 0)
            {
                return true;
            }

            return false;

        }
    }
}
