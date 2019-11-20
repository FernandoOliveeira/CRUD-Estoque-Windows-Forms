using Sistema_Estoque.BusinessLayer;
using Sistema_Estoque.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Estoque.ViewLayer
{
    public partial class FrmAtualizar : Form
    {
        #region código para tornar o form "arrastavel" 

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion


        public int TxtIdProduto { get; set; }
        public string TxtNomeProduto { get; set; }
        public string TxtPreco { get; set; }
        public int TxtQuantidade { get; set; }
        public string TxtCodBarras { get; set; }
        public DateTime DtValidade { get; set; }
        public string TxtCodProduto { get; set; }
        public string TxtLocalArmazenado { get; set; }
        public string TxtDescricao { get; set; }


        public FrmAtualizar()
        {
            InitializeComponent();

            this.Text = "Atualizar Produtos";

            DateTime primeiroDiaMes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            dtValidade.MinDate = primeiroDiaMes;

        }


        private void FrmAtualizar_Load(object sender, EventArgs e)
        {
            txtNomeProduto.Text = TxtNomeProduto;
            txtPreco.Text = TxtPreco;
            txtQuantidade.Value = TxtQuantidade;
            txtCodBarras.Text = TxtCodBarras;
            dtValidade.Value = DtValidade;
            txtCodProduto.Text = TxtCodProduto;
            txtLocalArmazenado.Text = TxtLocalArmazenado;
            txtDescricao.Text = TxtDescricao;
        }


        private void ArrastarTela_MouseDown(object sender, MouseEventArgs e)
        {
            #region código para tornar o form "arrastavel"
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
            #endregion


        }


        #region Buttons

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {

            btnMinimizar.BackColor = Color.FromArgb(255, 177, 66);

        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {

            btnMinimizar.BackColor = Color.FromArgb(44, 62, 80);

        }



        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // Faz com que a tela, quando maximizada, não cubra a barra de tarefas
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMaximizar_MouseEnter(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(205, 97, 51);

        }

        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(44, 62, 80);
        }



        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja mesmo sair ?\n(Todo o progresso não salvo será perdido)", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {

            btnSair.BackColor = Color.FromArgb(179, 57, 57);

        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.FromArgb(44, 62, 80);
        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            BlProduto objBlProduto = new BlProduto();

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
                    Descricao = txtDescricao.Text.Trim(),
                    IdProduto = TxtIdProduto
                    
                };


                if (objBlProduto.VerificarDadosProduto(objProduto))
                {



                    objBlProduto.AbrirBanco();
                    objBlProduto.AtualizarProdutos(objProduto);
                    objBlProduto.FecharBanco(objBlProduto.AbrirBanco());


                    MessageBox.Show("Produto atualizado com sucesso !", "Produto Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Um ou mais campos estão vazios\nPreencha todos os campos antes de continuar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Um ou mais campos estão vazios\nPreencha todos os campos antes de continuar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        #endregion


    }
}
