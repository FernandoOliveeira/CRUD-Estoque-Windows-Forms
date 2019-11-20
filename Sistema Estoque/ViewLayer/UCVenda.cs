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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DlProduto dlProduto = new DlProduto();

            if(dlProduto.VenderProdutos(txtNomeProduto.Text, (int)txtQuantidade.Value, txtCodProduto.Text))
            {
                MessageBox.Show("Venda efetuada com sucesso !", "Vendido com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não foi possível vender este item", "Erro ao realizar venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
