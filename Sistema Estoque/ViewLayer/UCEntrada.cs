using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Estoque.BusinessLayer;

namespace Sistema_Estoque.ViewLayer
{
    public partial class UCEntrada : UserControl
    {
        public UCEntrada()
        {
            InitializeComponent();
        }

        public void LimparCampos()
        {
            txtNomeProduto.Text = "";
            txtQuantidade.Value = 0;
            txtCodBarras.Text = "";
            dtValidade.Value = DateTime.Now;
            txtLocalArmazenado.Text = "";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            BlProduto blProduto = new BlProduto();

            if (blProduto.EntrarProdutos(txtNomeProduto.Text.Trim(), (int)txtQuantidade.Value, txtCodBarras.Text.Trim(), dtValidade.Value, txtLocalArmazenado.Text.Trim()))
            {
                MessageBox.Show("Entrada realizada com sucesso.", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Não foi possivel realizar a entrada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
            }
           

           

        }
    }
}
