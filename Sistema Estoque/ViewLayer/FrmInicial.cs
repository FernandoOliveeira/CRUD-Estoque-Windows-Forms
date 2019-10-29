﻿using System;
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
        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            painelLateral.Height = btnCadastrar.Height;
            painelLateral.Top = btnCadastrar.Top;
            ucCadastrar1.BringToFront();
        }



        #endregion

    }
}
