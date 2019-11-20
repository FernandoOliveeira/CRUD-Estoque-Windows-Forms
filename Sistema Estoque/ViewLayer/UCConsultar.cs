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
            BlProduto objBlProduto = new BlProduto();
            dgvConsulta.DataSource = objBlProduto.ConsultarProdutos();

        }


        
        private void rdbConsultarNome_CheckedChanged(object sender, EventArgs e)
        {
            txtConsultarNome.Focus();
            txtConsultarNome.Text = "";

            BlProduto objBlProduto = new BlProduto();
            dgvConsulta.DataSource = objBlProduto.ConsultarProdutos();

            if (rdbConsultarNome.Checked)
            {
                txtConsultarNome.Enabled = true;
                consultarNomePanelLine.BackColor = Color.Black;


                txtConsultarCodigo.Enabled = false;
                txtCodBarras.Enabled = false;

                consultarCodigoPanelLine.BackColor = Color.FromArgb(120, 120, 120);
                consultarCodBarrasPanelLine.BackColor = Color.FromArgb(120, 120, 120);
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

            BlProduto objBlProduto = new BlProduto();
            dgvConsulta.DataSource = objBlProduto.ConsultarProdutos();

            if (rdbConsultarCodigo.Checked)
            {
                txtConsultarCodigo.Enabled = true;
                consultarCodigoPanelLine.BackColor = Color.Black;


                txtConsultarNome.Enabled = false;
                txtCodBarras.Enabled = false;

                consultarNomePanelLine.BackColor = Color.FromArgb(120, 120, 120);
                consultarCodBarrasPanelLine.BackColor = Color.FromArgb(120, 120, 120);
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

            BlProduto objBlProduto = new BlProduto();
            dgvConsulta.DataSource = objBlProduto.ConsultarProdutos();

            if (rdbConsultarCodBarras.Checked)
            {
                txtCodBarras.Enabled = true;
                consultarCodBarrasPanelLine.BackColor = Color.Black;




                txtConsultarNome.Enabled = false;
                txtConsultarCodigo.Enabled = false;

                consultarNomePanelLine.BackColor = Color.FromArgb(120, 120, 120);
                consultarCodigoPanelLine.BackColor = Color.FromArgb(120, 120, 120);
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

                string idProduto = dgvConsulta.SelectedRows[0].Cells[1].Value.ToString();

                if (MessageBox.Show("Deseja atualizar este item ?\n" + idProduto.ToUpper(), "Atualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    FrmAtualizar frmAtualizar = new FrmAtualizar();

                    string dataValidade = dgvConsulta.SelectedRows[0].Cells[6].Value.ToString();

                    DateTime dtValidade = Convert.ToDateTime(dataValidade);



                    frmAtualizar.TxtIdProduto = (int) dgvConsulta.SelectedRows[0].Cells[0].Value;

                    frmAtualizar.TxtNomeProduto = dgvConsulta.SelectedRows[0].Cells[1].Value.ToString();

                    frmAtualizar.TxtPreco = dgvConsulta.SelectedRows[0].Cells[2].Value.ToString();

                    frmAtualizar.TxtQuantidade = (int) dgvConsulta.SelectedRows[0].Cells[3].Value;

                    frmAtualizar.TxtCodBarras = dgvConsulta.SelectedRows[0].Cells[4].Value.ToString();

                    frmAtualizar.TxtCodProduto = dgvConsulta.SelectedRows[0].Cells[5].Value.ToString();

                    frmAtualizar.DtValidade = dtValidade;

                    frmAtualizar.TxtLocalArmazenado = dgvConsulta.SelectedRows[0].Cells[7].Value.ToString();

                    frmAtualizar.TxtDescricao = dgvConsulta.SelectedRows[0].Cells[8].Value.ToString();


                    frmAtualizar.Show();

                }
            }

            if (dgvConsulta.Columns[e.ColumnIndex].Name == "EXCLUIR")
            {
                string idProduto = dgvConsulta.SelectedRows[0].Cells[1].Value.ToString();

                if (MessageBox.Show("Deseja realmente excluir este item ?\n" + idProduto.ToUpper() + "\n(Os dados serão excluídos permanentemente)", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int idProdutos = int.Parse(dgvConsulta.SelectedRows[0].Cells[0].Value.ToString());

                    BlProduto objBlProduto = new BlProduto();

                    objBlProduto.ExcluirProdutos(idProdutos);

                    MessageBox.Show("Item excluído com sucesso", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    dgvConsulta.DataSource = objBlProduto.ConsultarProdutos();


                }
            }
        }



    }
}
