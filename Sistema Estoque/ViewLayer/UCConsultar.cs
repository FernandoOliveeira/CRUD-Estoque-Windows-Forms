using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Estoque.ViewLayer
{
    public partial class UCConsultar : UserControl
    {
        public UCConsultar()
        {
            InitializeComponent();
        }




        private void UCConsultar_Load(object sender, EventArgs e)
        {
           
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

        
    }
}
