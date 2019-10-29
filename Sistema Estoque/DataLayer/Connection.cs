using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Sistema_Estoque.DataLayer
{
    class Connection
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;

        //Abrir banco de dados e conectar
        public SqlConnection AbrirBanco()
        {
            try
            {
                SqlConnection cn = new SqlConnection(connectionString);
                cn.Open();
                return cn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        // Fechar banco após inicialização
        public void FecharBanco(SqlConnection cn)
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
       

    }
}
