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
            this.tblCadastrar = new System.Windows.Forms.TableLayoutPanel();
            this.dataValidadePanel = new System.Windows.Forms.Panel();
            this.dtValidade = new System.Windows.Forms.DateTimePicker();
            this.lblDataValidade = new System.Windows.Forms.Label();
            this.quantidadePanel = new System.Windows.Forms.Panel();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nomeProdutoPanel = new System.Windows.Forms.Panel();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.localArmazenadoPanel = new System.Windows.Forms.Panel();
            this.lblLocalArmazenado = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtLocalArmazenado = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.tblCadastrar.SuspendLayout();
            this.dataValidadePanel.SuspendLayout();
            this.quantidadePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.nomeProdutoPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.localArmazenadoPanel.SuspendLayout();
            this.panel12.SuspendLayout();
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
            // tblCadastrar
            // 
            this.tblCadastrar.ColumnCount = 3;
            this.tblCadastrar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.41578F));
            this.tblCadastrar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.71935F));
            this.tblCadastrar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.86488F));
            this.tblCadastrar.Controls.Add(this.quantidadePanel, 2, 0);
            this.tblCadastrar.Controls.Add(this.nomeProdutoPanel, 0, 0);
            this.tblCadastrar.Controls.Add(this.panel12, 1, 3);
            this.tblCadastrar.Controls.Add(this.panel2, 0, 2);
            this.tblCadastrar.Controls.Add(this.localArmazenadoPanel, 2, 2);
            this.tblCadastrar.Controls.Add(this.dataValidadePanel, 1, 1);
            this.tblCadastrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCadastrar.Location = new System.Drawing.Point(0, 55);
            this.tblCadastrar.Name = "tblCadastrar";
            this.tblCadastrar.RowCount = 4;
            this.tblCadastrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.36245F));
            this.tblCadastrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.34061F));
            this.tblCadastrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.60262F));
            this.tblCadastrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.25764F));
            this.tblCadastrar.Size = new System.Drawing.Size(745, 458);
            this.tblCadastrar.TabIndex = 4;
            // 
            // dataValidadePanel
            // 
            this.dataValidadePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataValidadePanel.Controls.Add(this.dtValidade);
            this.dataValidadePanel.Controls.Add(this.lblDataValidade);
            this.dataValidadePanel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataValidadePanel.Location = new System.Drawing.Point(244, 110);
            this.dataValidadePanel.Name = "dataValidadePanel";
            this.dataValidadePanel.Size = new System.Drawing.Size(237, 69);
            this.dataValidadePanel.TabIndex = 1;
            // 
            // dtValidade
            // 
            this.dtValidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtValidade.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtValidade.Location = new System.Drawing.Point(7, 30);
            this.dtValidade.Name = "dtValidade";
            this.dtValidade.Size = new System.Drawing.Size(194, 22);
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
            // quantidadePanel
            // 
            this.quantidadePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantidadePanel.Controls.Add(this.txtQuantidade);
            this.quantidadePanel.Controls.Add(this.lblQuantidade);
            this.quantidadePanel.Controls.Add(this.panel6);
            this.quantidadePanel.Location = new System.Drawing.Point(487, 3);
            this.quantidadePanel.Name = "quantidadePanel";
            this.quantidadePanel.Size = new System.Drawing.Size(255, 101);
            this.quantidadePanel.TabIndex = 2;
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
            // nomeProdutoPanel
            // 
            this.nomeProdutoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeProdutoPanel.Controls.Add(this.lblNomeProduto);
            this.nomeProdutoPanel.Controls.Add(this.panel1);
            this.nomeProdutoPanel.Controls.Add(this.txtNomeProduto);
            this.nomeProdutoPanel.Location = new System.Drawing.Point(3, 3);
            this.nomeProdutoPanel.Name = "nomeProdutoPanel";
            this.nomeProdutoPanel.Size = new System.Drawing.Size(235, 101);
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblCodProduto);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtCodProduto);
            this.panel2.Location = new System.Drawing.Point(3, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 125);
            this.panel2.TabIndex = 3;
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProduto.ForeColor = System.Drawing.Color.White;
            this.lblCodProduto.Location = new System.Drawing.Point(3, 10);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(150, 20);
            this.lblCodProduto.TabIndex = 4;
            this.lblCodProduto.Text = "Código do Produto";
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
            // txtCodProduto
            // 
            this.txtCodProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCodProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtCodProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(103)))));
            this.txtCodProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProduto.ForeColor = System.Drawing.Color.White;
            this.txtCodProduto.Location = new System.Drawing.Point(7, 29);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(225, 19);
            this.txtCodProduto.TabIndex = 3;
            // 
            // localArmazenadoPanel
            // 
            this.localArmazenadoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.localArmazenadoPanel.Controls.Add(this.lblLocalArmazenado);
            this.localArmazenadoPanel.Controls.Add(this.panel10);
            this.localArmazenadoPanel.Controls.Add(this.txtLocalArmazenado);
            this.localArmazenadoPanel.Location = new System.Drawing.Point(487, 194);
            this.localArmazenadoPanel.Name = "localArmazenadoPanel";
            this.localArmazenadoPanel.Size = new System.Drawing.Size(255, 125);
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
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.Controls.Add(this.btnCadastrar);
            this.panel12.Location = new System.Drawing.Point(244, 325);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(237, 41);
            this.panel12.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(7, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(194, 36);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Enviar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // UCEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.tblCadastrar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "UCEntrada";
            this.Size = new System.Drawing.Size(745, 513);
            this.tblCadastrar.ResumeLayout(false);
            this.dataValidadePanel.ResumeLayout(false);
            this.dataValidadePanel.PerformLayout();
            this.quantidadePanel.ResumeLayout(false);
            this.quantidadePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.nomeProdutoPanel.ResumeLayout(false);
            this.nomeProdutoPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.localArmazenadoPanel.ResumeLayout(false);
            this.localArmazenadoPanel.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tblCadastrar;
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
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Panel localArmazenadoPanel;
        private System.Windows.Forms.Label lblLocalArmazenado;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtLocalArmazenado;
    }
}
