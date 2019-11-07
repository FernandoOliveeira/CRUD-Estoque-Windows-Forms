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
    public partial class UCConsultar : UserControl 
    {
        UcAtualizar UcAtualizar = new UcAtualizar();


        public UCConsultar()
        {
            InitializeComponent();
        }

        UCCadastrar objCadastrar;

        public UCConsultar(UCCadastrar obj)
        {
            this.objCadastrar = obj;
            InitializeComponent();
        }




        private void UCConsultar_Load(object sender, EventArgs e)
        {

            //BlProduto objBlProduto = new BlProduto();
            //dgvConsulta.DataSource = objBlProduto.ConsultarProdutos();

        }


        
        private void rdbConsultarNome_CheckedChanged(object sender, EventArgs e)
        {
            txtConsultarNome.Focus();
            txtConsultarNome.Text = "";

            if (rdbConsultarNome.Checked)
            {
                txtConsultarNome.Enabled = true;
                consultarNomePanelLine.BackColor = Color.Black;


                txtConsultarCodigo.Enabled = false;
                txtCodBarras.Enabled = false;

                consultarCodigoPanelLine.BackColor = Color.FromArgb(120, 120, 120);
                consultarCodBarrasPanelLine.BackColor = Color.FromArgb(120, 120, 120);
            }
            else
            {

            }
        }

        private void txtConsultarNome_TextChanged(object sender, EventArgs e)
        {
            BlProduto objBlProduto = new BlProduto();

            if (txtConsultarNome.Text.Length != 0)
            {
                dgvConsulta.DataSource = objBlProduto.ConsultarProdutosNome(txtConsultarNome.Text);
            }
            else
            {
                dgvConsulta.DataSource = objBlProduto.ConsultarProdutos();
            }
        }



        private void rdbConsultarCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtConsultarCodigo.Focus();
            txtConsultarCodigo.Text = "";

            if (rdbConsultarCodigo.Checked)
            {
                txtConsultarCodigo.Enabled = true;
                consultarCodigoPanelLine.BackColor = Color.Black;


                txtConsultarNome.Enabled = false;
                txtCodBarras.Enabled = false;

                consultarNomePanelLine.BackColor = Color.FromArgb(120, 120, 120);
                consultarCodBarrasPanelLine.BackColor = Color.FromArgb(120, 120, 120);
            }
            else
            {

            }
        }

        private void txtConsultarCodigo_TextChanged(object sender, EventArgs e)
        {
            BlProduto objBlProduto = new BlProduto();

            if (txtConsultarCodigo.Text.Length != 0)
            {
                dgvConsulta.DataSource = objBlProduto.ConsultarProdutosCodigo(txtConsultarCodigo.Text);
            }
            else
            {
                dgvConsulta.DataSource = objBlProduto.ConsultarProdutos();
            }
        }


        private void rdbConsultarCodBarras_CheckedChanged(object sender, EventArgs e)
        {
            
            txtCodBarras.Focus();
            txtCodBarras.Text = "";

            if (rdbConsultarCodBarras.Checked)
            {
                txtCodBarras.Enabled = true;
                consultarCodBarrasPanelLine.BackColor = Color.Black;




                txtConsultarNome.Enabled = false;
                txtConsultarCodigo.Enabled = false;

                consultarNomePanelLine.BackColor = Color.FromArgb(120, 120, 120);
                consultarCodigoPanelLine.BackColor = Color.FromArgb(120, 120, 120);
            }
            else
            {

            }
        }



        private void txtCodBarras_TextChanged(object sender, EventArgs e)
        {
            BlProduto objBlProduto = new BlProduto();

            if (txtCodBarras.Text.Length != 0)
            {
                dgvConsulta.DataSource = objBlProduto.ConsultarProdutosCodBarras(txtCodBarras.Text);
            }
            else
            {
                dgvConsulta.DataSource = objBlProduto.ConsultarProdutos();
            }
        }




        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsulta.Columns[e.ColumnIndex].Name == "ATUALIZAR")
            {
                if (MessageBox.Show("Deseja Atualizar este item", "Atualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    UcAtualizar UcAtualizar = new UcAtualizar();
                    UcAtualizar.Location = new Point(0, 0);
                    Controls.Add(UcAtualizar);

                    UcAtualizar.Dock = DockStyle.Fill;

                    lblTitulo.Text = "Atualizar Produtos";

                    UcAtualizar.BringToFront();


                }
            }
        }



    }
}
