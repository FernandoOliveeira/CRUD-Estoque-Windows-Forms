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



        private void UCCadastrar_Load(object sender, EventArgs e)
        {
            txtNomeProduto.Text = "Nome do produto";
            txtPreco.Text = "Preço";
            txtCodBarras.Text = "Código de barras";
            txtLocalArmazenado.Text = "Local de armazenamento";
            txtDescricao.Text = "Descrição";

            txtNomeProduto.ForeColor = Color.Gray;
            txtPreco.ForeColor = Color.Gray;
            txtQuantidade.ForeColor = Color.Gray;
            txtCodBarras.ForeColor = Color.Gray;
            txtLocalArmazenado.ForeColor = Color.Gray;
            txtDescricao.ForeColor = Color.Gray;
        }


        
        private void LimparCampos()
        {
            txtNomeProduto.Text = "";
            txtPreco.Text = "";
            txtQuantidade.Value = 0;
            txtCodBarras.Text = "";
            dtValidade.Value = DateTime.Now;
            txtLocalArmazenado.Text = "";
            txtDescricao.Text = "";
        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            BlProduto objBlProduto = new BlProduto();
            Produto objProduto = new Produto();

           
            objProduto.NomeProduto = txtNomeProduto.Text;
            objProduto.Preco = double.Parse(txtPreco.Text.Replace(',', '.'));
            objProduto.Quantidade = (int)txtQuantidade.Value;
            objProduto.CodBarras = txtCodBarras.Text;
            objProduto.DataValidade = DateTime.Parse(dtValidade.Text);
            objProduto.LocalArmazenamento = txtLocalArmazenado.Text;
            objProduto.Descricao = txtDescricao.Text;

            objBlProduto.AbrirBanco();
            objBlProduto.CadastrarProduto(objProduto);
            objBlProduto.FecharBanco(objBlProduto.AbrirBanco());
            LimparCampos();

            MessageBox.Show("Produto cadastrado com sucesso !", "Produto Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }


        #region PlaceHolder's


        private void txtNomeProduto_Enter(object sender, EventArgs e)
        {
            if (txtNomeProduto.Text == "Nome do produto")
            {
                txtNomeProduto.Text = "";
                txtNomeProduto.ForeColor = Color.White;
            }
        }

        private void txtNomeProduto_Leave(object sender, EventArgs e)
        {
            if (txtNomeProduto.Text == "")
            {
                txtNomeProduto.Text = "Nome do produto";
                txtNomeProduto.ForeColor = Color.Gray;
            }
        }



        private void txtPreco_Enter(object sender, EventArgs e)
        {
            if (txtPreco.Text == "Preço")
            {
                txtPreco.Text = "";
                txtPreco.ForeColor = Color.White;
            }
        }

        private void txtPreco_Leave(object sender, EventArgs e)
        {
            if (txtPreco.Text == "")
            {
                txtPreco.Text = "Preço";
                txtPreco.ForeColor = Color.Gray;
            }
        }



        private void txtQuantidade_Enter(object sender, EventArgs e)
        {
            if (txtQuantidade.Text == "0")
            {
                txtQuantidade.Text = "";
                txtQuantidade.ForeColor = Color.White;
            }
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            if (txtQuantidade.Text == "")
            {
                txtQuantidade.Text = "0";
                txtQuantidade.ForeColor = Color.Gray;
            }
        }



        private void txtCodBarras_Enter(object sender, EventArgs e)
        {
            if (txtCodBarras.Text == "Código de barras")
            {
                txtCodBarras.Text = "";
                txtCodBarras.ForeColor = Color.White;
            }
        }

        private void txtCodBarras_Leave(object sender, EventArgs e)
        {
            if (txtCodBarras.Text == "")
            {
                txtCodBarras.Text = "Código de barras";
                txtCodBarras.ForeColor = Color.Gray;
            }
        }



        private void txtLocalArmazenado_Enter(object sender, EventArgs e)
        {
            if (txtLocalArmazenado.Text == "Local de armazenamento")
            {
                txtLocalArmazenado.Text = "";
                txtLocalArmazenado.Font = new Font("Century Gothic", 11);
                txtLocalArmazenado.ForeColor = Color.White;
            }
        }

        private void txtLocalArmazenado_Leave(object sender, EventArgs e)
        {
            if (txtLocalArmazenado.Text == "")
            {
                txtLocalArmazenado.Font = new Font("Century Gothic", 9);
                txtLocalArmazenado.Text = "Local de armazenamento";
                txtLocalArmazenado.ForeColor = Color.Gray;
            }
        }



        private void txtDescricao_Enter(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "Descrição")
            {
                txtDescricao.Text = "";
                txtDescricao.ForeColor = Color.Black;
            }
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                txtDescricao.Text = "Descrição";
                txtDescricao.ForeColor = Color.Gray;
            }
        }



        #endregion

        
    }
}
