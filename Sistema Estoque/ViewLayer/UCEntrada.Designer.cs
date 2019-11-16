namespace Sistema_Estoque.ViewLayer
{
    partial class UCEntrada
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tblEntrada = new System.Windows.Forms.TableLayoutPanel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCodBarras = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.nomeProdutoPanel = new System.Windows.Forms.Panel();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.dataValidadePanel = new System.Windows.Forms.Panel();
            this.dtValidade = new System.Windows.Forms.DateTimePicker();
            this.lblDataValidade = new System.Windows.Forms.Label();
            this.localArmazenadoPanel = new System.Windows.Forms.Panel();
            this.lblLocalArmazenado = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtLocalArmazenado = new System.Windows.Forms.TextBox();
            this.quantidadePanel = new System.Windows.Forms.Panel();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tblEntrada.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel2.SuspendLayout();
            this.nomeProdutoPanel.SuspendLayout();
            this.dataValidadePanel.SuspendLayout();
            this.localArmazenadoPanel.SuspendLayout();
            this.quantidadePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(745, 55);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Entrada de Produtos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblEntrada
            // 
            this.tblEntrada.ColumnCount = 3;
            this.tblEntrada.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.41578F));
            this.tblEntrada.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.71935F));
            this.tblEntrada.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.86488F));
            this.tblEntrada.Controls.Add(this.panel12, 1, 3);
            this.tblEntrada.Controls.Add(this.panel2, 0, 2);
            this.tblEntrada.Controls.Add(this.nomeProdutoPanel, 0, 1);
            this.tblEntrada.Controls.Add(this.dataValidadePanel, 1, 2);
            this.tblEntrada.Controls.Add(this.localArmazenadoPanel, 2, 2);
            this.tblEntrada.Controls.Add(this.quantidadePanel, 2, 1);
            this.tblEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEntrada.Location = new System.Drawing.Point(0, 55);
            this.tblEntrada.Name = "tblEntrada";
            this.tblEntrada.RowCount = 4;
            this.tblEntrada.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.27493F));
            this.tblEntrada.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.30413F));
            this.tblEntrada.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.42093F));
            this.tblEntrada.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tblEntrada.Size = new System.Drawing.Size(745, 458);
            this.tblEntrada.TabIndex = 4;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.Controls.Add(this.btnEnviar);
            this.panel12.Location = new System.Drawing.Point(244, 414);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(237, 41);
            this.panel12.TabIndex = 5;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(8, 2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(207, 36);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblCodBarras);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtCodBarras);
            this.panel2.Location = new System.Drawing.Point(3, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 230);
            this.panel2.TabIndex = 2;
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodBarras.ForeColor = System.Drawing.Color.White;
            this.lblCodBarras.Location = new System.Drawing.Point(3, 10);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(137, 20);
            this.lblCodBarras.TabIndex = 4;
            this.lblCodBarras.Text = "Código de Barras\r\n";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(7, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 1);
            this.panel3.TabIndex = 5;
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodBarras.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCodBarras.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtCodBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(103)))));
            this.txtCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodBarras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarras.ForeColor = System.Drawing.Color.White;
            this.txtCodBarras.Location = new System.Drawing.Point(7, 29);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(225, 19);
            this.txtCodBarras.TabIndex = 3;
            // 
            // nomeProdutoPanel
            // 
            this.nomeProdutoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeProdutoPanel.Controls.Add(this.lblNomeProduto);
            this.nomeProdutoPanel.Controls.Add(this.panel1);
            this.nomeProdutoPanel.Controls.Add(this.txtNomeProduto);
            this.nomeProdutoPanel.Location = new System.Drawing.Point(3, 74);
            this.nomeProdutoPanel.Name = "nomeProdutoPanel";
            this.nomeProdutoPanel.Size = new System.Drawing.Size(235, 98);
            this.nomeProdutoPanel.TabIndex = 0;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.ForeColor = System.Drawing.Color.White;
            this.lblNomeProduto.Location = new System.Drawing.Point(3, 3);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(139, 20);
            this.lblNomeProduto.TabIndex = 4;
            this.lblNomeProduto.Text = "Nome do Produto";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(7, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 1);
            this.panel1.TabIndex = 5;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNomeProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtNomeProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(103)))));
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.ForeColor = System.Drawing.Color.White;
            this.txtNomeProduto.Location = new System.Drawing.Point(7, 23);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(214, 19);
            this.txtNomeProduto.TabIndex = 3;
            // 
            // dataValidadePanel
            // 
            this.dataValidadePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataValidadePanel.Controls.Add(this.dtValidade);
            this.dataValidadePanel.Controls.Add(this.lblDataValidade);
            this.dataValidadePanel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataValidadePanel.Location = new System.Drawing.Point(244, 178);
            this.dataValidadePanel.Name = "dataValidadePanel";
            this.dataValidadePanel.Size = new System.Drawing.Size(237, 69);
            this.dataValidadePanel.TabIndex = 3;
            // 
            // dtValidade
            // 
            this.dtValidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtValidade.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtValidade.Location = new System.Drawing.Point(7, 30);
            this.dtValidade.Name = "dtValidade";
            this.dtValidade.Size = new System.Drawing.Size(208, 22);
            this.dtValidade.TabIndex = 6;
            // 
            // lblDataValidade
            // 
            this.lblDataValidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataValidade.AutoSize = true;
            this.lblDataValidade.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataValidade.ForeColor = System.Drawing.Color.White;
            this.lblDataValidade.Location = new System.Drawing.Point(4, 10);
            this.lblDataValidade.Name = "lblDataValidade";
            this.lblDataValidade.Size = new System.Drawing.Size(140, 20);
            this.lblDataValidade.TabIndex = 5;
            this.lblDataValidade.Text = "Data de Validade";
            // 
            // localArmazenadoPanel
            // 
            this.localArmazenadoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.localArmazenadoPanel.Controls.Add(this.lblLocalArmazenado);
            this.localArmazenadoPanel.Controls.Add(this.panel10);
            this.localArmazenadoPanel.Controls.Add(this.txtLocalArmazenado);
            this.localArmazenadoPanel.Location = new System.Drawing.Point(487, 178);
            this.localArmazenadoPanel.Name = "localArmazenadoPanel";
            this.localArmazenadoPanel.Size = new System.Drawing.Size(255, 230);
            this.localArmazenadoPanel.TabIndex = 4;
            // 
            // lblLocalArmazenado
            // 
            this.lblLocalArmazenado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocalArmazenado.AutoSize = true;
            this.lblLocalArmazenado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalArmazenado.ForeColor = System.Drawing.Color.White;
            this.lblLocalArmazenado.Location = new System.Drawing.Point(4, 7);
            this.lblLocalArmazenado.Name = "lblLocalArmazenado";
            this.lblLocalArmazenado.Size = new System.Drawing.Size(198, 20);
            this.lblLocalArmazenado.TabIndex = 4;
            this.lblLocalArmazenado.Text = "Local de Armazenamento";
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(7, 46);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(212, 1);
            this.panel10.TabIndex = 5;
            // 
            // txtLocalArmazenado
            // 
            this.txtLocalArmazenado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocalArmazenado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLocalArmazenado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtLocalArmazenado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(103)))));
            this.txtLocalArmazenado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocalArmazenado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalArmazenado.ForeColor = System.Drawing.Color.White;
            this.txtLocalArmazenado.Location = new System.Drawing.Point(7, 30);
            this.txtLocalArmazenado.Name = "txtLocalArmazenado";
            this.txtLocalArmazenado.Size = new System.Drawing.Size(212, 19);
            this.txtLocalArmazenado.TabIndex = 3;
            // 
            // quantidadePanel
            // 
            this.quantidadePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantidadePanel.Controls.Add(this.txtQuantidade);
            this.quantidadePanel.Controls.Add(this.lblQuantidade);
            this.quantidadePanel.Controls.Add(this.panel6);
            this.quantidadePanel.Location = new System.Drawing.Point(487, 74);
            this.quantidadePanel.Name = "quantidadePanel";
            this.quantidadePanel.Size = new System.Drawing.Size(255, 98);
            this.quantidadePanel.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(103)))));
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidade.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.ForeColor = System.Drawing.Color.White;
            this.txtQuantidade.Location = new System.Drawing.Point(7, 21);
            this.txtQuantidade.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(245, 22);
            this.txtQuantidade.TabIndex = 3;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblQuantidade.Location = new System.Drawing.Point(3, 3);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(98, 20);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(7, 39);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(245, 1);
            this.panel6.TabIndex = 5;
            // 
            // UCEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.tblEntrada);
            this.Controls.Add(this.lblTitulo);
            this.Name = "UCEntrada";
            this.Size = new System.Drawing.Size(745, 513);
            this.tblEntrada.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.nomeProdutoPanel.ResumeLayout(false);
            this.nomeProdutoPanel.PerformLayout();
            this.dataValidadePanel.ResumeLayout(false);
            this.dataValidadePanel.PerformLayout();
            this.localArmazenadoPanel.ResumeLayout(false);
            this.localArmazenadoPanel.PerformLayout();
            this.quantidadePanel.ResumeLayout(false);
            this.quantidadePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tblEntrada;
        private System.Windows.Forms.Panel dataValidadePanel;
        private System.Windows.Forms.DateTimePicker dtValidade;
        private System.Windows.Forms.Label lblDataValidade;
        private System.Windows.Forms.Panel quantidadePanel;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel nomeProdutoPanel;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCodBarras;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Panel localArmazenadoPanel;
        private System.Windows.Forms.Label lblLocalArmazenado;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtLocalArmazenado;
    }
}
