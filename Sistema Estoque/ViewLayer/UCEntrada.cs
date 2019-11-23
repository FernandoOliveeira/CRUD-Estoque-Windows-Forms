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

        private void UCEntrada_Load(object sender, EventArgs e)
        {
            dtValidade.MinDate = DateTime.Now;
            dtValidade.Value = DateTime.Now;
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

            if (txtQuantidade.Value <= 0)
            {
                MessageBox.Show("Quantidade de entrada inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (txtNomeProduto.Text.Trim() == "" || txtQuantidade.Value == 0 || txtCodBarras.Text.Trim() == "" || txtLocalArmazenado.Text == "")
                {
                    // Entra nesta condição caso TODOS os inputs estejam vazios

                    MessageBox.Show("Não foi possivel realizar a entrada\nUm ou mais campos estão vazios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {

                    try
                    {

                        if (blProduto.EntrarProdutos(txtNomeProduto.Text.Trim(), (int)txtQuantidade.Value, txtCodBarras.Text.Trim(), dtValidade.Value, txtLocalArmazenado.Text.Trim()) && txtQuantidade.Value != 0 && txtLocalArmazenado.Text != "")
                        {
                            MessageBox.Show("Entrada realizada com sucesso.", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimparCampos();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel realizar a entrada\nNome do produto ou código de barras inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Não Foi possível realizar a entrada\nNome do produto ou código de barras inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }

        }

        
    }
}
