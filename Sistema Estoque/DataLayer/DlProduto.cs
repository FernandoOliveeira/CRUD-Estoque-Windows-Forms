﻿using Sistema_Estoque.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Estoque.DataLayer
{
    class DlProduto : Connection
    {

        public DataTable ConsultarProdutos()
        {
            DataTable consultaProduto = new DataTable();

            string queryStr = "SELECT ID_PRODUTOS, NOME, PRECO, QUANTIDADE, DATA_VALIDADE, COD_BARRAS, COD_PRODUTO, LOCAL_ARMAZENADO,  DESCRICAO, DATA_CADASTRO FROM PRODUTOS ORDER BY NOME";

            SqlCommand command = new SqlCommand(queryStr, AbrirBanco());
            SqlDataReader reader = command.ExecuteReader();
            consultaProduto.Load(reader);

            return consultaProduto;
        }

        public DataTable ConsultarProdutosCodBarras(string codBarras)
        {
            DataTable consultaProduto = new DataTable();

            string queryStr = "SELECT ID_PRODUTOS, NOME, PRECO, QUANTIDADE, DATA_VALIDADE, COD_BARRAS, COD_PRODUTO, LOCAL_ARMAZENADO,  DESCRICAO, DATA_CADASTRO FROM PRODUTOS WHERE COD_BARRAS LIKE '%" + codBarras + "%' ORDER BY COD_BARRAS";

            SqlCommand command = new SqlCommand(queryStr, AbrirBanco());
            SqlDataReader reader = command.ExecuteReader();
            consultaProduto.Load(reader);

            return consultaProduto;
        }

        public DataTable ConsultarProdutosCodigo(string codigo)
        {

            DataTable consultaProduto = new DataTable();

            string queryStr = "SELECT ID_PRODUTOS, NOME, PRECO, QUANTIDADE, DATA_VALIDADE, COD_BARRAS, COD_PRODUTO, LOCAL_ARMAZENADO,  DESCRICAO, DATA_CADASTRO FROM PRODUTOS WHERE COD_PRODUTO LIKE '%" + codigo + "%' ORDER BY COD_PRODUTO ";

            SqlCommand command = new SqlCommand(queryStr, AbrirBanco());
            SqlDataReader reader = command.ExecuteReader();
            consultaProduto.Load(reader);

            return consultaProduto;

        }

        public DataTable ConsultarProdutosNome(string nome)
        {
            
            DataTable consultaProduto = new DataTable();

            string queryStr = "SELECT ID_PRODUTOS, NOME, PRECO, QUANTIDADE, DATA_VALIDADE, COD_BARRAS, COD_PRODUTO, LOCAL_ARMAZENADO,  DESCRICAO, DATA_CADASTRO FROM PRODUTOS WHERE NOME LIKE '%" + nome +"%' ORDER BY NOME ";

            SqlCommand command = new SqlCommand(queryStr, AbrirBanco());
            SqlDataReader reader = command.ExecuteReader();
            consultaProduto.Load(reader);

            return consultaProduto;
            
        }



        public bool AtualizarProdutos(Produto produto)
        {
            string queryStr = "UPDATE PRODUTOS SET NOME= @nomeProduto, PRECO = @preco, QUANTIDADE = @quantidade, COD_BARRAS = @codBarras, COD_PRODUTO = @codProduto, DATA_VALIDADE =  @dataValidade, LOCAL_ARMAZENADO = @localArmazenado, DESCRICAO = @descricao WHERE ID_PRODUTOS = @idProduto";

            SqlCommand command = new SqlCommand(queryStr, AbrirBanco());
            command.Parameters.AddWithValue("@nomeProduto", produto.NomeProduto);
            command.Parameters.AddWithValue("@preco", produto.Preco);
            command.Parameters.AddWithValue("@quantidade", produto.Quantidade);
            command.Parameters.AddWithValue("@codBarras", produto.CodBarras);
            command.Parameters.AddWithValue("@codProduto", produto.CodProduto);
            command.Parameters.AddWithValue("@dataValidade", produto.DataValidade);
            command.Parameters.AddWithValue("@localArmazenado", produto.LocalArmazenamento);
            command.Parameters.AddWithValue("@descricao", produto.Descricao);
            command.Parameters.AddWithValue("@idProduto", produto.IdProduto);

            int res = command.ExecuteNonQuery();

            FecharBanco(AbrirBanco());

            if (res != 0)
            {

                return true;
            }


            return false;

        }

        public bool CadastrarProdutos(Produto produto)
        {
            string querystr = "INSERT INTO PRODUTOS VALUES(@nomeProduto, @preco, @quantidade, @codBarras, @codProduto, @dataValidade, @localArmazenado, @descricao, @dataCadastro)";

            SqlCommand command = new SqlCommand(querystr, AbrirBanco());
            command.Parameters.AddWithValue("@nomeProduto", produto.NomeProduto);
            command.Parameters.AddWithValue("@preco", produto.Preco);
            command.Parameters.AddWithValue("@quantidade", produto.Quantidade);
            command.Parameters.AddWithValue("@codBarras", produto.CodBarras);
            command.Parameters.AddWithValue("@codProduto", produto.CodProduto);
            command.Parameters.AddWithValue("@dataValidade", produto.DataValidade);
            command.Parameters.AddWithValue("@localArmazenado", produto.LocalArmazenamento);
            command.Parameters.AddWithValue("@descricao", produto.Descricao);
            command.Parameters.AddWithValue("@dataCadastro", DateTime.Now);

            int res = command.ExecuteNonQuery();

            FecharBanco(AbrirBanco());

            if (res != 0)
            {

                return true;
            }


            return false;

        }

        public bool ExcluirProdutos(int idProduto)
        {
            string queryStr = "DELETE FROM PRODUTOS WHERE ID_PRODUTOS = " + idProduto;

            SqlCommand command = new SqlCommand(queryStr, AbrirBanco());

            int res = command.ExecuteNonQuery();

            FecharBanco(AbrirBanco());

            if (res != 0)
            {

                return true;
            }

            return false;
        }

        public bool VerificarProdutosCodBarras(string codBarras)
        {

            DataTable consultaProduto = new DataTable();


            string queryStr = "SELECT COD_BARRAS FROM PRODUTOS WHERE COD_BARRAS = '" + codBarras + "'";

            SqlCommand command = new SqlCommand(queryStr, AbrirBanco());
            SqlDataReader reader = command.ExecuteReader();

            consultaProduto.Load(reader);

            string codigoBarras = " ";

            foreach (DataRow row in consultaProduto.Rows)
            {
                codigoBarras = row["COD_BARRAS"].ToString();
            }

            FecharBanco(AbrirBanco());

            if (codigoBarras == codBarras)
            {
                codigoBarras = " ";

                return true;
            }

            codigoBarras = " ";

            return false;


        }

        public bool VerificarProdutosNome(string nome)
        {
            DataTable consultaProduto = new DataTable();


            string queryStr = "SELECT NOME FROM PRODUTOS WHERE NOME = '" + nome + "'";

            SqlCommand command = new SqlCommand(queryStr, AbrirBanco());
            SqlDataReader reader = command.ExecuteReader();

            consultaProduto.Load(reader);

            string nomeProduto = " ";

            foreach (DataRow row in consultaProduto.Rows)
            {
                nomeProduto = row["NOME"].ToString();
            }

            FecharBanco(AbrirBanco());

            if (nomeProduto == nome)
            {
                nomeProduto = " ";

                return true;
            }

            nomeProduto = " ";

            return false;
        }
        
        public bool VerificarProdutosCodProduto(string codProduto)
        {
            DataTable consultaProduto = new DataTable();


            string queryStr = "SELECT COD_PRODUTO FROM PRODUTOS WHERE COD_PRODUTO = '" + codProduto + "'";

            SqlCommand command = new SqlCommand(queryStr, AbrirBanco());
            SqlDataReader reader = command.ExecuteReader();

            consultaProduto.Load(reader);

            string codigoProduto = " ";

            foreach (DataRow row in consultaProduto.Rows)
            {
                codigoProduto = row["COD_PRODUTO"].ToString();
            }

            FecharBanco(AbrirBanco());

            if (codigoProduto == codProduto)
            {
                codigoProduto = " ";

                return true;
            }

            codigoProduto = " ";

            return false;
        }

        public bool VerificarQuantidadeEstoque(int quantidade, string codProduto)
        {
            DataTable consultaEstoque = new DataTable();

            string queryConsultarEstoque = "SELECT QUANTIDADE FROM PRODUTOS WHERE COD_PRODUTO = '" + codProduto + "'";
            SqlCommand command = new SqlCommand(queryConsultarEstoque, AbrirBanco());
            SqlDataReader reader = command.ExecuteReader();

            consultaEstoque.Load(reader);

            int quantidadeEstoque = 0;

            foreach (DataRow row in consultaEstoque.Rows)
            {
                quantidadeEstoque = int.Parse(row["QUANTIDADE"].ToString());
            }

            FecharBanco(AbrirBanco());

            if (quantidade > quantidadeEstoque)
            {

                quantidadeEstoque = 0;

                return true;
            }

            return false;

        }

        public bool EntrarProdutos(string nome, int quantidadeEntrada, string codBarras, DateTime dataValidade, string localArmazenado)
        {
            DataTable consultarProdutos = new DataTable();

            string queryStr = "SELECT ID_PRODUTOS, NOME, QUANTIDADE, COD_BARRAS, DATA_VALIDADE, LOCAL_ARMAZENADO FROM PRODUTOS WHERE NOME = '" + nome + "' AND COD_BARRAS = '" + codBarras + "'";

            SqlCommand command = new SqlCommand(queryStr, AbrirBanco());
            SqlDataReader reader = command.ExecuteReader();

            consultarProdutos.Load(reader);

            int idProdutos = 0;
            int quantidadeEstoque = 0;

            foreach (DataRow row in consultarProdutos.Rows)
            {
                idProdutos = int.Parse(row["ID_PRODUTOS"].ToString());
                quantidadeEstoque = int.Parse(row["QUANTIDADE"].ToString());
            }


            int quantidadeTotal = quantidadeEntrada + quantidadeEstoque;


            string queryEntrarProduto = "UPDATE PRODUTOS SET QUANTIDADE = " + quantidadeTotal + ", DATA_VALIDADE = '" + dataValidade + "', LOCAL_ARMAZENADO = '" + localArmazenado + "' WHERE ID_PRODUTOS = " + idProdutos;

            SqlCommand commandEntrarProduto = new SqlCommand(queryEntrarProduto, AbrirBanco());

            int res = commandEntrarProduto.ExecuteNonQuery();

            FecharBanco(AbrirBanco());

            if (res != 0)
            {

                return true;
            }

            return false;

        }

        public bool VenderProdutos(int quantidade, string codProduto)
        {
            DataTable consultaProdutos = new DataTable();

            string queryStr = "SELECT ID_PRODUTOS, PRECO, QUANTIDADE FROM PRODUTOS WHERE COD_PRODUTO = '" + codProduto + "'";

            SqlCommand command = new SqlCommand(queryStr, AbrirBanco());
            SqlDataReader reader = command.ExecuteReader();

            consultaProdutos.Load(reader);

            // Variáveis que irão receber os valores do banco de dados
            int idProdutos = 0;
            int quantidadeEstoque = 0;
            double preco = 0;

            
            foreach (DataRow row in consultaProdutos.Rows)
            {
                // Associa os dados do banco e atribui os valores nas respectivas variáveis
                idProdutos = int.Parse(row["ID_PRODUTOS"].ToString());
                quantidadeEstoque = int.Parse(row["QUANTIDADE"].ToString());
                preco = double.Parse(row["PRECO"].ToString());
            }



            int quantidadeVendida = quantidade;

            double valorTotalVenda = preco * quantidadeVendida;

            int quantidadeTotal = quantidadeEstoque - quantidadeVendida;


            string queryVendas = "INSERT INTO VENDAS(QUANTIDADE_VENDIDA, VALOR_TOTAL_VENDA, ID_PRODUTOS) VALUES( @quantidadeVendida , @valorTotalVenda , @idProdutos )";

            SqlCommand commandVendas = new SqlCommand(queryVendas, AbrirBanco());
            commandVendas.Parameters.AddWithValue("@quantidadeVendida", quantidadeVendida);
            commandVendas.Parameters.AddWithValue("@valorTotalVenda", valorTotalVenda);
            commandVendas.Parameters.AddWithValue("@idProdutos", idProdutos);
            int Vendas = commandVendas.ExecuteNonQuery();


            string queryAtualizarProduto = "UPDATE PRODUTOS SET QUANTIDADE = " + quantidadeTotal + "WHERE ID_PRODUTOS = " + idProdutos;
            SqlCommand commandAtualizarProduto = new SqlCommand(queryAtualizarProduto, AbrirBanco());
            int AtualizarProduto = commandAtualizarProduto.ExecuteNonQuery();

            FecharBanco(AbrirBanco());

            if (Vendas != 0 && AtualizarProduto != 0)
            {

                return true;
            }


            return false;
        }


        public string VerificarVendaProdutos(string codProduto)
        {
            DataTable consultaEstoque = new DataTable();

            string queryConsultarEstoque = "SELECT NOME FROM PRODUTOS WHERE COD_PRODUTO = '" + codProduto + "'";
            SqlCommand command = new SqlCommand(queryConsultarEstoque, AbrirBanco());
            SqlDataReader reader = command.ExecuteReader();

            consultaEstoque.Load(reader);

            string nomeProduto = "";

            foreach (DataRow row in consultaEstoque.Rows)
            {
                nomeProduto = row["NOME"].ToString();
            }

            return nomeProduto;


        }

    }
}
