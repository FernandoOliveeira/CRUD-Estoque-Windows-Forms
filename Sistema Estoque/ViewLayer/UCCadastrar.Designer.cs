namespace Sistema_Estoque.ViewLayer
{
    partial class UCCadastrar
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
            this.tblCadastrar = new System.Windows.Forms.TableLayoutPanel();
            this.dataValidadePanel = new System.Windows.Forms.Panel();
            this.dtValidade = new System.Windows.Forms.DateTimePicker();
            this.lblDataValidade = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.descricaoPanel = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.localArmazenadoPanel = new System.Windows.Forms.Panel();
            this.lblLocalArmazenado = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtLocalArmazenado = new System.Windows.Forms.TextBox();
            this.codBarrasPanel = new System.Windows.Forms.Panel();
            this.lblCodBarras = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.quantidadePanel = new System.Windows.Forms.Panel();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.precoPanel = new System.Windows.Forms.Panel();
            this.lblPreco = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.nomeProdutoPanel = new System.Windows.Forms.Panel();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.tblCadastrar.SuspendLayout();
            this.dataValidadePanel.SuspendLayout();
            this.panel12.SuspendLayout();
            this.descricaoPanel.SuspendLayout();
            this.localArmazenadoPanel.SuspendLayout();
            this.codBarrasPanel.SuspendLayout();
            this.quantidadePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.precoPanel.SuspendLayout();
            this.nomeProdutoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(211, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cadastrar Produtos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblCadastrar
            // 
            this.tblCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblCadastrar.ColumnCount = 3;
            this.tblCadastrar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblCadastrar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblCadastrar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblCadastrar.Controls.Add(this.dataValidadePanel, 1, 1);
            this.tblCadastrar.Controls.Add(this.panel12, 1, 3);
            this.tblCadastrar.Controls.Add(this.descricaoPanel, 0, 2);
            this.tblCadastrar.Controls.Add(this.localArmazenadoPanel, 2, 1);
            this.tblCadastrar.Controls.Add(this.codBarrasPanel, 0, 1);
            this.tblCadastrar.Controls.Add(this.quantidadePanel, 2, 0);
            this.tblCadastrar.Controls.Add(this.precoPanel, 1, 0);
            this.tblCadastrar.Controls.Add(this.nomeProdutoPanel, 0, 0);
            this.tblCadastrar.Location = new System.Drawing.Point(3, 63);
            this.tblCadastrar.Name = "tblCadastrar";
            this.tblCadastrar.RowCount = 4;
            this.tblCadastrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.79696F));
            this.tblCadastrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.28934F));
            this.tblCadastrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.32487F));
            this.tblCadastrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.33503F));
            this.tblCadastrar.Size = new System.Drawing.Size(714, 394);
            this.tblCadastrar.TabIndex = 2;
            // 
            // dataValidadePanel
            // 
            this.dataValidadePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataValidadePanel.Controls.Add(this.dtValidade);
            this.dataValidadePanel.Controls.Add(this.lblDataValidade);
            this.dataValidadePanel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataValidadePanel.Location = new System.Drawing.Point(241, 81);
            this.dataValidadePanel.Name = "dataValidadePanel";
            this.dataValidadePanel.Size = new System.Drawing.Size(232, 70);
            this.dataValidadePanel.TabIndex = 4;
            // 
            // dtValidade
            // 
            this.dtValidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtValidade.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtValidade.Location = new System.Drawing.Point(7, 26);
            this.dtValidade.Name = "dtValidade";
            this.dtValidade.Size = new System.Drawing.Size(192, 22);
            this.dtValidade.TabIndex = 6;
            // 
            // lblDataValidade
            // 
            this.lblDataValidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataValidade.AutoSize = true;
            this.lblDataValidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataValidade.ForeColor = System.Drawing.Color.White;
            this.lblDataValidade.Location = new System.Drawing.Point(4, 6);
            this.lblDataValidade.Name = "lblDataValidade";
            this.lblDataValidade.Size = new System.Drawing.Size(125, 17);
            this.lblDataValidade.TabIndex = 5;
            this.lblDataValidade.Text = "Data de Validade";
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.Controls.Add(this.btnCadastrar);
            this.panel12.Location = new System.Drawing.Point(241, 308);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(232, 83);
            this.panel12.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(29, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(127, 36);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // descricaoPanel
            // 
            this.descricaoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblCadastrar.SetColumnSpan(this.descricaoPanel, 3);
            this.descricaoPanel.Controls.Add(this.txtDescricao);
            this.descricaoPanel.Controls.Add(this.lblDescricao);
            this.descricaoPanel.Location = new System.Drawing.Point(3, 157);
            this.descricaoPanel.Name = "descricaoPanel";
            this.descricaoPanel.Size = new System.Drawing.Size(708, 145);
            this.descricaoPanel.TabIndex = 6;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(6, 23);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(697, 119);
            this.txtDescricao.TabIndex = 5;
            this.txtDescricao.Text = "";
            this.txtDescricao.Enter += new System.EventHandler(this.txtDescricao_Enter);
            this.txtDescricao.Leave += new System.EventHandler(this.txtDescricao_Leave);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(3, 3);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(177, 17);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Local de Armazenamento";
            // 
            // localArmazenadoPanel
            // 
            this.localArmazenadoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.localArmazenadoPanel.Controls.Add(this.lblLocalArmazenado);
            this.localArmazenadoPanel.Controls.Add(this.panel10);
            this.localArmazenadoPanel.Controls.Add(this.txtLocalArmazenado);
            this.localArmazenadoPanel.Location = new System.Drawing.Point(479, 81);
            this.localArmazenadoPanel.Name = "localArmazenadoPanel";
            this.localArmazenadoPanel.Size = new System.Drawing.Size(232, 70);
            this.localArmazenadoPanel.TabIndex = 5;
            // 
            // lblLocalArmazenado
            // 
            this.lblLocalArmazenado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocalArmazenado.AutoSize = true;
            this.lblLocalArmazenado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalArmazenado.ForeColor = System.Drawing.Color.White;
            this.lblLocalArmazenado.Location = new System.Drawing.Point(4, 6);
            this.lblLocalArmazenado.Name = "lblLocalArmazenado";
            this.lblLocalArmazenado.Size = new System.Drawing.Size(177, 17);
            this.lblLocalArmazenado.TabIndex = 4;
            this.lblLocalArmazenado.Text = "Local de Armazenamento";
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(7, 43);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(143, 1);
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
            this.txtLocalArmazenado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalArmazenado.ForeColor = System.Drawing.Color.White;
            this.txtLocalArmazenado.Location = new System.Drawing.Point(7, 27);
            this.txtLocalArmazenado.Name = "txtLocalArmazenado";
            this.txtLocalArmazenado.Size = new System.Drawing.Size(143, 15);
            this.txtLocalArmazenado.TabIndex = 3;
            this.txtLocalArmazenado.Enter += new System.EventHandler(this.txtLocalArmazenado_Enter);
            this.txtLocalArmazenado.Leave += new System.EventHandler(this.txtLocalArmazenado_Leave);
            // 
            // codBarrasPanel
            // 
            this.codBarrasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codBarrasPanel.Controls.Add(this.lblCodBarras);
            this.codBarrasPanel.Controls.Add(this.panel8);
            this.codBarrasPanel.Controls.Add(this.txtCodBarras);
            this.codBarrasPanel.Location = new System.Drawing.Point(3, 81);
            this.codBarrasPanel.Name = "codBarrasPanel";
            this.codBarrasPanel.Size = new System.Drawing.Size(232, 70);
            this.codBarrasPanel.TabIndex = 3;
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodBarras.ForeColor = System.Drawing.Color.White;
            this.lblCodBarras.Location = new System.Drawing.Point(3, 3);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(137, 20);
            this.lblCodBarras.TabIndex = 4;
            this.lblCodBarras.Text = "Código de Barras";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(7, 38);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 1);
            this.panel8.TabIndex = 5;
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCodBarras.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtCodBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(103)))));
            this.txtCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodBarras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarras.ForeColor = System.Drawing.Color.White;
            this.txtCodBarras.Location = new System.Drawing.Point(7, 21);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(200, 19);
            this.txtCodBarras.TabIndex = 3;
            this.txtCodBarras.Enter += new System.EventHandler(this.txtCodBarras_Enter);
            this.txtCodBarras.Leave += new System.EventHandler(this.txtCodBarras_Leave);
            // 
            // quantidadePanel
            // 
            this.quantidadePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantidadePanel.Controls.Add(this.txtQuantidade);
            this.quantidadePanel.Controls.Add(this.lblQuantidade);
            this.quantidadePanel.Controls.Add(this.panel6);
            this.quantidadePanel.Location = new System.Drawing.Point(479, 3);
            this.quantidadePanel.Name = "quantidadePanel";
            this.quantidadePanel.Size = new System.Drawing.Size(232, 72);
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
            this.txtQuantidade.Location = new System.Drawing.Point(7, 20);
            this.txtQuantidade.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(143, 22);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.Enter += new System.EventHandler(this.txtQuantidade_Enter);
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
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
            this.panel6.Size = new System.Drawing.Size(143, 1);
            this.panel6.TabIndex = 5;
            // 
            // precoPanel
            // 
            this.precoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.precoPanel.Controls.Add(this.lblPreco);
            this.precoPanel.Controls.Add(this.panel4);
            this.precoPanel.Controls.Add(this.txtPreco);
            this.precoPanel.Location = new System.Drawing.Point(241, 3);
            this.precoPanel.Name = "precoPanel";
            this.precoPanel.Size = new System.Drawing.Size(232, 72);
            this.precoPanel.TabIndex = 1;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.White;
            this.lblPreco.Location = new System.Drawing.Point(3, 3);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(53, 20);
            this.lblPreco.TabIndex = 4;
            this.lblPreco.Text = "Preço";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(7, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 1);
            this.panel4.TabIndex = 5;
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPreco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(103)))));
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreco.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.ForeColor = System.Drawing.Color.White;
            this.txtPreco.Location = new System.Drawing.Point(7, 22);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(192, 19);
            this.txtPreco.TabIndex = 3;
            this.txtPreco.Enter += new System.EventHandler(this.txtPreco_Enter);
            this.txtPreco.Leave += new System.EventHandler(this.txtPreco_Leave);
            // 
            // nomeProdutoPanel
            // 
            this.nomeProdutoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeProdutoPanel.Controls.Add(this.lblNomeProduto);
            this.nomeProdutoPanel.Controls.Add(this.panel1);
            this.nomeProdutoPanel.Controls.Add(this.txtNomeProduto);
            this.nomeProdutoPanel.Location = new System.Drawing.Point(3, 3);
            this.nomeProdutoPanel.Name = "nomeProdutoPanel";
            this.nomeProdutoPanel.Size = new System.Drawing.Size(232, 72);
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
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(7, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 5;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNomeProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtNomeProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(103)))));
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.ForeColor = System.Drawing.Color.White;
            this.txtNomeProduto.Location = new System.Drawing.Point(7, 22);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(200, 19);
            this.txtNomeProduto.TabIndex = 3;
            this.txtNomeProduto.Enter += new System.EventHandler(this.txtNomeProduto_Enter);
            this.txtNomeProduto.Leave += new System.EventHandler(this.txtNomeProduto_Leave);
            // 
            // UCCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.tblCadastrar);
            this.Controls.Add(this.label2);
            this.Name = "UCCadastrar";
            this.Size = new System.Drawing.Size(745, 513);
            this.Load += new System.EventHandler(this.UCCadastrar_Load);
            this.tblCadastrar.ResumeLayout(false);
            this.dataValidadePanel.ResumeLayout(false);
            this.dataValidadePanel.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.descricaoPanel.ResumeLayout(false);
            this.descricaoPanel.PerformLayout();
            this.localArmazenadoPanel.ResumeLayout(false);
            this.localArmazenadoPanel.PerformLayout();
            this.codBarrasPanel.ResumeLayout(false);
            this.codBarrasPanel.PerformLayout();
            this.quantidadePanel.ResumeLayout(false);
            this.quantidadePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.precoPanel.ResumeLayout(false);
            this.precoPanel.PerformLayout();
            this.nomeProdutoPanel.ResumeLayout(false);
            this.nomeProdutoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tblCadastrar;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Panel nomeProdutoPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Panel quantidadePanel;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel precoPanel;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Panel codBarrasPanel;
        private System.Windows.Forms.Label lblCodBarras;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Panel localArmazenadoPanel;
        private System.Windows.Forms.Label lblLocalArmazenado;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtLocalArmazenado;
        private System.Windows.Forms.Panel descricaoPanel;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel dataValidadePanel;
        private System.Windows.Forms.DateTimePicker dtValidade;
        private System.Windows.Forms.Label lblDataValidade;
    }
}
