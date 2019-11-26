using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Estoque.DataLayer;

namespace Sistema_Estoque.ViewLayer
{
    public partial class UCVenda : UserControl
    {
        public UCVenda()
        {
            InitializeComponent();
        }

        public void LimparCampos()
        {
            txtNomeProduto.Text = "";
            txtQuantidade.Value = 0;
            txtCodProduto.Text = "";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DlProduto objDlProduto = new DlProduto();

            if (objDlProduto.VerificarProdutosNome(txtNomeProduto.Text))
            {
                if (objDlProduto.VerificarProdutosCodProduto(txtCodProduto.Text))
                {



                    if (txtQuantidade.Value <= 0)
                    {
                        MessageBox.Show("Quantidade inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        if (objDlProduto.VerificarQuantidadeEstoque(txtNomeProduto.Text.Trim(), (int)txtQuantidade.Value, txtCodProduto.Text.Trim()))
                        {
                            MessageBox.Show("Quantidade digitada maior que a quantidade em estoque", "Quantidade inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {

                            if (objDlProduto.VenderProdutos(txtNomeProduto.Text.Trim(), (int)txtQuantidade.Value, txtCodProduto.Text.Trim()))
                            {
                                MessageBox.Show("Venda efetuada com sucesso !", "Vendido com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimparCampos();
                            }
                            else
                            {
                                MessageBox.Show("Não foi possível vender este item", "Erro ao realizar venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Código do produto não encontrado !", "Código não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nome de produto não encontrado !", "Produto não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
