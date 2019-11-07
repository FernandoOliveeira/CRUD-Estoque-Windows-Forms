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
    public partial class UcAtualizar : UserControl
    {
        public UcAtualizar()
        {
            InitializeComponent();
        }

        public UCCadastrar UcCadastrar { get; set; }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            
            this.Parent.Controls.Remove(this);
        }
    }
}
