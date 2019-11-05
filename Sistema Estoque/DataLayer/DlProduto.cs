using Sistema_Estoque.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
            string querystr = "INSERT INTO PRODUTOS VALUES(@nomeProduto, @preco, @quantidade, @codBarras, @codProduto, @dataValidade, @localArmazenado, @descricao)";

            SqlCommand command = new SqlCommand(querystr, AbrirBanco());
            command.Parameters.AddWithValue("@nomeProduto", produto.NomeProduto);
            command.Parameters.AddWithValue("@preco", produto.Preco);
            command.Parameters.AddWithValue("@quantidade", produto.Quantidade);
            command.Parameters.AddWithValue("@codBarras", produto.CodBarras);
            command.Parameters.AddWithValue("@codProduto", produto.CodBarras);
            command.Parameters.AddWithValue("@dataValidade", produto.DataValidade);
            command.Parameters.AddWithValue("@localArmazenado", produto.LocalArmazenamento);
            command.Parameters.AddWithValue("@descricao", produto.Descricao);

            int res = command.ExecuteNonQuery();

            if (res != 0)
            {
                return true;
            }

            return false;

        }

        public DataTable ConsultarProdutos()
        {
            DataTable consultaProduto = new DataTable();

            string queryStr = "SELECT NOME, PRECO, QUANTIDADE, DATA_VALIDADE, COD_BARRAS, COD_PRODUTO, LOCAL_ARMAZENADO,  DESCRICAO, DATA_CADASTRO FROM PRODUTOS ORDER BY ID_PRODUTOS";
            SqlCommand command = new SqlCommand(queryStr, AbrirBanco());
            SqlDataReader reader = command.ExecuteReader();
            consultaProduto.Load(reader);

            return consultaProduto;
        }

        public DataTable ConsultarProdutosNome(string nome)
        {
            
            DataTable consultaProduto = new DataTable();

            string queryStr = "SELECT NOME, PRECO, QUANTIDADE, DATA_VALIDADE, COD_BARRAS, COD_PRODUTO, LOCAL_ARMAZENADO,  DESCRICAO, DATA_CADASTRO FROM PRODUTOS WHERE NOME LIKE '%" + nome +"%' ORDER BY NOME ";
            SqlCommand command = new SqlCommand(queryStr, AbrirBanco());
            SqlDataReader reader = command.ExecuteReader();
            consultaProduto.Load(reader);

            return consultaProduto;
            
        }


        public DataTable ConsultarProdutosCodigo(string codigo)
        {

            DataTable consultaProduto = new DataTable();

            string queryStr = "SELECT NOME, PRECO, QUANTIDADE, DATA_VALIDADE, COD_BARRAS, COD_PRODUTO, LOCAL_ARMAZENADO,  DESCRICAO, DATA_CADASTRO FROM PRODUTOS WHERE COD_PRODUTO LIKE '%" + codigo + "%' ORDER BY COD_PRODUTO ";
            SqlCommand command = new SqlCommand(queryStr, AbrirBanco());
            SqlDataReader reader = command.ExecuteReader();
            consultaProduto.Load(reader);

            return consultaProduto;

        }

        public DataTable ConsultarProdutosCodBarras(string codBarras)
        {
            DataTable consultaProduto = new DataTable();

            string queryStr = "SELECT NOME, PRECO, QUANTIDADE, DATA_VALIDADE, COD_BARRAS, COD_PRODUTO, LOCAL_ARMAZENADO,  DESCRICAO, DATA_CADASTRO FROM PRODUTOS WHERE COD_BARRAS LIKE '%" + codBarras + "%' ORDER BY COD_BARRAS";
            SqlCommand command = new SqlCommand(queryStr, AbrirBanco());
            SqlDataReader reader = command.ExecuteReader();
            consultaProduto.Load(reader);

            return consultaProduto;
        }

    }
}
