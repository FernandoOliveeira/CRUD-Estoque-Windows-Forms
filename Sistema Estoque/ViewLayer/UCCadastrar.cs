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
using Sistema_Estoque.Model;

namespace Sistema_Estoque.ViewLayer
{
    public partial class UCCadastrar : UserControl
    {
        public UCCadastrar()
        {
            InitializeComponent();
            dtValidade.MinDate = DateTime.Now;
            dtValidade.Value = DateTime.Now;
        }

        
        private void LimparCampos()
        {
            txtNomeProduto.Text = "";
            txtPreco.Text = "";
            txtQuantidade.Value = 0;
            txtCodBarras.Text = "";
            txtCodProduto.Text = "";
            dtValidade.Value = DateTime.Now;
            txtLocalArmazenado.Text = "";
            txtDescricao.Text = "";
        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            BlProduto objBlProduto = new BlProduto();


            if (objBlProduto.VerificarProdutosCodBarras(txtCodBarras.Text.Trim()))
            {
                MessageBox.Show("Já existe um cadastro com este mesmo código de barras", "Cadastro já existente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                try
                {
                    Produto objProduto = new Produto
                    {
                        NomeProduto = txtNomeProduto.Text.Trim(),
                        Preco = double.Parse(txtPreco.Text.Replace('.', ',').Trim()),
                        Quantidade = (int)txtQuantidade.Value,
                        CodBarras = txtCodBarras.Text.Trim(),
                        CodProduto = txtCodProduto.Text.Trim(),
                        DataValidade = DateTime.Parse(dtValidade.Text),
                        LocalArmazenamento = txtLocalArmazenado.Text.Trim(),
                        Descricao = txtDescricao.Text.Trim()
                    };


                    if (objBlProduto.VerificarDadosProduto(objProduto))
                    {
                        objBlProduto.AbrirBanco();
                        objBlProduto.CadastrarProdutos(objProduto);
                        objBlProduto.FecharBanco(objBlProduto.AbrirBanco());

                        MessageBox.Show("Produto cadastrado com sucesso !", "Produto Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimparCampos();

                    }
                    else
                    {

                        MessageBox.Show("Um ou mais campos estão vazios\nPreencha todos os campos antes de continuar", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
                catch (Exception)
                {

                    MessageBox.Show("Um ou mais campos estão vazios\nPreencha todos os campos antes de continuar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }


        // Permite apenas números no campo Preco
        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Permite apenas um separador decimal
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }


    }
}
