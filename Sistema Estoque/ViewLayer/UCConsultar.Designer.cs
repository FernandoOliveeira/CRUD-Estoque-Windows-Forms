namespace Sistema_Estoque.ViewLayer
{
    partial class UCConsultar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.tblConsultar = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridPanel = new System.Windows.Forms.Panel();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtConsultarNome = new System.Windows.Forms.TextBox();
            this.rdbConsultarNome = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtConsultarCodigo = new System.Windows.Forms.TextBox();
            this.rdbConsultarCodigo = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tblConsultar.SuspendLayout();
            this.dataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(745, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consultar Produtos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblConsultar
            // 
            this.tblConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblConsultar.ColumnCount = 2;
            this.tblConsultar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblConsultar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblConsultar.Controls.Add(this.dataGridPanel, 0, 2);
            this.tblConsultar.Controls.Add(this.panel1, 0, 0);
            this.tblConsultar.Controls.Add(this.panel3, 1, 0);
            this.tblConsultar.Location = new System.Drawing.Point(7, 42);
            this.tblConsultar.Name = "tblConsultar";
            this.tblConsultar.RowCount = 3;
            this.tblConsultar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.13953F));
            this.tblConsultar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.86047F));
            this.tblConsultar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tblConsultar.Size = new System.Drawing.Size(720, 401);
            this.tblConsultar.TabIndex = 3;
            // 
            // dataGridPanel
            // 
            this.dataGridPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblConsultar.SetColumnSpan(this.dataGridPanel, 2);
            this.dataGridPanel.Controls.Add(this.dgvConsulta);
            this.dataGridPanel.Location = new System.Drawing.Point(3, 139);
            this.dataGridPanel.Name = "dataGridPanel";
            this.dataGridPanel.Size = new System.Drawing.Size(714, 259);
            this.dataGridPanel.TabIndex = 0;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.AllowUserToOrderColumns = true;
            this.dgvConsulta.AllowUserToResizeRows = false;
            this.dgvConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.dgvConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(3, 0);
            this.dgvConsulta.MultiSelect = false;
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(708, 232);
            this.dgvConsulta.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtConsultarNome);
            this.panel1.Controls.Add(this.rdbConsultarNome);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 73);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(5, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 2;
            // 
            // txtConsultarNome
            // 
            this.txtConsultarNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultarNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtConsultarNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtConsultarNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(103)))));
            this.txtConsultarNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsultarNome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultarNome.ForeColor = System.Drawing.Color.White;
            this.txtConsultarNome.Location = new System.Drawing.Point(4, 24);
            this.txtConsultarNome.Name = "txtConsultarNome";
            this.txtConsultarNome.Size = new System.Drawing.Size(200, 19);
            this.txtConsultarNome.TabIndex = 1;
            // 
            // rdbConsultarNome
            // 
            this.rdbConsultarNome.AutoSize = true;
            this.rdbConsultarNome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbConsultarNome.ForeColor = System.Drawing.Color.White;
            this.rdbConsultarNome.Location = new System.Drawing.Point(3, 3);
            this.rdbConsultarNome.Name = "rdbConsultarNome";
            this.rdbConsultarNome.Size = new System.Drawing.Size(266, 24);
            this.rdbConsultarNome.TabIndex = 0;
            this.rdbConsultarNome.TabStop = true;
            this.rdbConsultarNome.Text = "Consultar pelo nome do produto";
            this.rdbConsultarNome.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.txtConsultarCodigo);
            this.panel3.Controls.Add(this.rdbConsultarCodigo);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(363, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 73);
            this.panel3.TabIndex = 2;
            // 
            // txtConsultarCodigo
            // 
            this.txtConsultarCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultarCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtConsultarCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtConsultarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(103)))));
            this.txtConsultarCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsultarCodigo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultarCodigo.ForeColor = System.Drawing.Color.White;
            this.txtConsultarCodigo.Location = new System.Drawing.Point(4, 24);
            this.txtConsultarCodigo.Name = "txtConsultarCodigo";
            this.txtConsultarCodigo.Size = new System.Drawing.Size(200, 19);
            this.txtConsultarCodigo.TabIndex = 1;
            // 
            // rdbConsultarCodigo
            // 
            this.rdbConsultarCodigo.AutoSize = true;
            this.rdbConsultarCodigo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbConsultarCodigo.ForeColor = System.Drawing.Color.White;
            this.rdbConsultarCodigo.Location = new System.Drawing.Point(3, 3);
            this.rdbConsultarCodigo.Name = "rdbConsultarCodigo";
            this.rdbConsultarCodigo.Size = new System.Drawing.Size(277, 24);
            this.rdbConsultarCodigo.TabIndex = 0;
            this.rdbConsultarCodigo.TabStop = true;
            this.rdbConsultarCodigo.Text = "Consultar pelo código do produto";
            this.rdbConsultarCodigo.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(5, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 1);
            this.panel4.TabIndex = 3;
            // 
            // UCConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.tblConsultar);
            this.Controls.Add(this.label2);
            this.Name = "UCConsultar";
            this.Size = new System.Drawing.Size(745, 513);
            this.tblConsultar.ResumeLayout(false);
            this.dataGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tblConsultar;
        private System.Windows.Forms.Panel dataGridPanel;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtConsultarNome;
        private System.Windows.Forms.RadioButton rdbConsultarNome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdbConsultarCodigo;
        private System.Windows.Forms.TextBox txtConsultarCodigo;
        private System.Windows.Forms.Panel panel4;
    }
}
