﻿using System;
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
    public partial class UCCadastrar : UserControl
    {
        public UCCadastrar()
        {
            InitializeComponent();
            dtValidade.MinDate = DateTime.Now;
            dtValidade.Value = DateTime.Now;
        }

    }
}
