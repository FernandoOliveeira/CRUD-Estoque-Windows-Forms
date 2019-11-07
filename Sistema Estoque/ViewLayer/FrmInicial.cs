using Sistema_Estoque.ViewLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Estoque
{
    public partial class FrmInicial : Form
    {
        #region código para tornar o form "arrastavel" 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public FrmInicial()
        {
            InitializeComponent();


            
            painelLateral.Height = btnHome.Height;
            painelLateral.Top = btnHome.Top;
            ucHome1.BringToFront();
            btnHome.Font = new Font(btnHome.Font, FontStyle.Bold);
            btnHome.ForeColor = Color.FromArgb(25, 181, 254);

        }

        UcAtualizar UcAtualizar = new UcAtualizar();


        // Código para detectar qual UserControl está na frente
        private bool UserControlFront(Control control)
        {
            if (control.Parent.Controls.GetChildIndex(control) == 0)
            {
                return true;
            }

            return false;
        }



        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            #region código para tornar o form "arrastavel"
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
            #endregion


        }



        private void topLeftPanel_MouseDown(object sender, MouseEventArgs e)
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



        private void btnHome_Click(object sender, EventArgs e)
        {
            
            painelLateral.Height = btnHome.Height;
            painelLateral.Top = btnHome.Top;
            ucHome1.BringToFront();


            if (UserControlFront(ucHome1))
            {
                btnHome.Font = new Font(btnHome.Font,  FontStyle.Bold);
                btnHome.ForeColor = Color.FromArgb(25, 181, 254);



                btnCadastrarProdutos.Font = new Font(btnCadastrarProdutos.Font, FontStyle.Regular);
                btnCadastrarProdutos.ForeColor = Color.FromArgb(255, 255, 255);

                btnConsultar.Font = new Font(btnConsultar.Font, FontStyle.Regular);
                btnConsultar.ForeColor = Color.FromArgb(255, 255, 255);
            }

        }



        private void btnCadastrarProdutos_Click(object sender, EventArgs e)
        {
            
            painelLateral.Height = btnCadastrarProdutos.Height;
            painelLateral.Top = btnCadastrarProdutos.Top;
            ucCadastrar1.BringToFront();


            if (UserControlFront(ucCadastrar1))
            {
                btnCadastrarProdutos.Font = new Font(btnCadastrarProdutos.Font, FontStyle.Bold);
                btnCadastrarProdutos.ForeColor = Color.FromArgb(25, 181, 254);



                btnHome.Font = new Font(btnHome.Font, FontStyle.Regular);
                btnHome.ForeColor = Color.FromArgb(255, 255, 255);

                btnConsultar.Font = new Font(btnConsultar.Font, FontStyle.Regular);
                btnConsultar.ForeColor = Color.FromArgb(255, 255, 255);
            }
                

        }




        private void btnConsultar_Click(object sender, EventArgs e)
        {
            painelLateral.Height = btnConsultar.Height;
            painelLateral.Top = btnConsultar.Top;
            ucConsultar1.BringToFront();

            if (UserControlFront(ucConsultar1))
            {
                btnConsultar.Font = new Font(btnCadastrarProdutos.Font, FontStyle.Bold);
                btnConsultar.ForeColor = Color.FromArgb(25, 181, 254);



                btnHome.Font = new Font(btnHome.Font, FontStyle.Regular);
                btnHome.ForeColor = Color.FromArgb(255, 255, 255);

                btnCadastrarProdutos.Font = new Font(btnCadastrarProdutos.Font, FontStyle.Regular);
                btnCadastrarProdutos.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }



        private void btnVenda_Click(object sender, EventArgs e)
        {

        }




        private void btnEntrada_Click(object sender, EventArgs e)
        {

        }

        #endregion




    }
}
