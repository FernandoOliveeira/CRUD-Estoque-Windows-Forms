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

            txtQuantidade.Value = 0;
            txtCodProduto.Text = "";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DlProduto objDlProduto = new DlProduto();


            if (objDlProduto.VerificarProdutosCodProduto(txtCodProduto.Text)) // Verifica se o código do produto existe no banco no dados
            {

                if (txtQuantidade.Value <= 0)
                {
                    MessageBox.Show("Quantidade inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (objDlProduto.VerificarQuantidadeEstoque((int)txtQuantidade.Value, txtCodProduto.Text.Trim())) // Verifica se a quantidade digitada não é maior que a quantidade em estoque
                    {
                        MessageBox.Show("Quantidade digitada maior que a quantidade em estoque", "Quantidade inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {

                        if (MessageBox.Show("Deseja vender este item ?\n" + objDlProduto.VerificarVendaProdutos(txtCodProduto.Text.Trim()), "Vender Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            if (objDlProduto.VenderProdutos((int)txtQuantidade.Value, txtCodProduto.Text.Trim())) // Realiza a baixa do produto
                            {
                                MessageBox.Show("Venda Realizada com sucesso !", "Vendido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LimparCampos();
                            }

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


    }
}
