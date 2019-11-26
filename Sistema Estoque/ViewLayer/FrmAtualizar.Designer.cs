namespace Sistema_Estoque.ViewLayer
{
    partial class FrmAtualizar
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAtualizar));
            this.topPanel = new System.Windows.Forms.Panel();
            this.lblTopPanel = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tblAtualizar = new System.Windows.Forms.TableLayoutPanel();
            this.dataValidadePanel = new System.Windows.Forms.Panel();
            this.dtValidade = new System.Windows.Forms.DateTimePicker();
            this.lblDataValidade = new System.Windows.Forms.Label();
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
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.descricaoPanel = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.localArmazenadoPanel = new System.Windows.Forms.Panel();
            this.lblLocalArmazenado = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtLocalArmazenado = new System.Windows.Forms.TextBox();
            this.topPanel.SuspendLayout();
            this.tblAtualizar.SuspendLayout();
            this.dataValidadePanel.SuspendLayout();
            this.codBarrasPanel.SuspendLayout();
            this.quantidadePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.precoPanel.SuspendLayout();
            this.nomeProdutoPanel.SuspendLayout();
            this.panel12.SuspendLayout();
            this.descricaoPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.localArmazenadoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.topPanel.Controls.Add(this.lblTopPanel);
            this.topPanel.Controls.Add(this.btnMinimizar);
            this.topPanel.Controls.Add(this.btnMaximizar);
            this.topPanel.Controls.Add(this.btnSair);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1152, 28);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ArrastarTela_MouseDown);
            // 
            // lblTopPanel
            // 
            this.lblTopPanel.AutoSize = true;
            this.lblTopPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopPanel.ForeColor = System.Drawing.Color.White;
            this.lblTopPanel.Location = new System.Drawing.Point(3, 4);
            this.lblTopPanel.Name = "lblTopPanel";
            this.lblTopPanel.Size = new System.Drawing.Size(376, 21);
            this.lblTopPanel.TabIndex = 11;
            this.lblTopPanel.Text = "CRUD - Sistema de Estoque - Atualizar Produtos";
            this.lblTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ArrastarTela_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(1059, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(31, 28);
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.Text = "—";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            this.btnMinimizar.MouseEnter += new System.EventHandler(this.btnMinimizar_MouseEnter);
            this.btnMinimizar.MouseLeave += new System.EventHandler(this.btnMinimizar_MouseLeave);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.Location = new System.Drawing.Point(1090, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(31, 28);
            this.btnMaximizar.TabIndex = 9;
            this.btnMaximizar.Text = "☐";
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            this.btnMaximizar.MouseEnter += new System.EventHandler(this.btnMaximizar_MouseEnter);
            this.btnMaximizar.MouseLeave += new System.EventHandler(this.btnMaximizar_MouseLeave);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(1121, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(31, 28);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "✕";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.MouseEnter += new System.EventHandler(this.btnSair_MouseEnter);
            this.btnSair.MouseLeave += new System.EventHandler(this.btnSair_MouseLeave);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1152, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "Atualizar Produtos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblAtualizar
            // 
            this.tblAtualizar.ColumnCount = 3;
            this.tblAtualizar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.44782F));
            this.tblAtualizar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.75168F));
            this.tblAtualizar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.89933F));
            this.tblAtualizar.Controls.Add(this.dataValidadePanel, 1, 1);
            this.tblAtualizar.Controls.Add(this.codBarrasPanel, 0, 1);
            this.tblAtualizar.Controls.Add(this.quantidadePanel, 2, 0);
            this.tblAtualizar.Controls.Add(this.precoPanel, 1, 0);
            this.tblAtualizar.Controls.Add(this.nomeProdutoPanel, 0, 0);
            this.tblAtualizar.Controls.Add(this.panel12, 1, 4);
            this.tblAtualizar.Controls.Add(this.descricaoPanel, 0, 3);
            this.tblAtualizar.Controls.Add(this.panel2, 2, 1);
            this.tblAtualizar.Controls.Add(this.localArmazenadoPanel, 1, 2);
            this.tblAtualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblAtualizar.Location = new System.Drawing.Point(0, 83);
            this.tblAtualizar.Name = "tblAtualizar";
            this.tblAtualizar.RowCount = 5;
            this.tblAtualizar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.84492F));
            this.tblAtualizar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tblAtualizar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.24104F));
            this.tblAtualizar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.23127F));
            this.tblAtualizar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tblAtualizar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblAtualizar.Size = new System.Drawing.Size(1152, 517);
            this.tblAtualizar.TabIndex = 5;
            // 
            // dataValidadePanel
            // 
            this.dataValidadePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataValidadePanel.Controls.Add(this.dtValidade);
            this.dataValidadePanel.Controls.Add(this.lblDataValidade);
            this.dataValidadePanel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataValidadePanel.Location = new System.Drawing.Point(376, 82);
            this.dataValidadePanel.Name = "dataValidadePanel";
            this.dataValidadePanel.Size = new System.Drawing.Size(370, 77);
            this.dataValidadePanel.TabIndex = 4;
            // 
            // dtValidade
            // 
            this.dtValidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtValidade.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtValidade.Location = new System.Drawing.Point(7, 43);
            this.dtValidade.Name = "dtValidade";
            this.dtValidade.Size = new System.Drawing.Size(327, 22);
            this.dtValidade.TabIndex = 6;
            // 
            // lblDataValidade
            // 
            this.lblDataValidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataValidade.AutoSize = true;
            this.lblDataValidade.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataValidade.ForeColor = System.Drawing.Color.White;
            this.lblDataValidade.Location = new System.Drawing.Point(4, 3);
            this.lblDataValidade.Name = "lblDataValidade";
            this.lblDataValidade.Size = new System.Drawing.Size(140, 20);
            this.lblDataValidade.TabIndex = 5;
            this.lblDataValidade.Text = "Data de Validade";
            // 
            // codBarrasPanel
            // 
            this.codBarrasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codBarrasPanel.Controls.Add(this.lblCodBarras);
            this.codBarrasPanel.Controls.Add(this.panel8);
            this.codBarrasPanel.Controls.Add(this.txtCodBarras);
            this.codBarrasPanel.Location = new System.Drawing.Point(3, 82);
            this.codBarrasPanel.Name = "codBarrasPanel";
            this.codBarrasPanel.Size = new System.Drawing.Size(367, 77);
            this.codBarrasPanel.TabIndex = 3;
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodBarras.ForeColor = System.Drawing.Color.White;
            this.lblCodBarras.Location = new System.Drawing.Point(4, 3);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(137, 20);
            this.lblCodBarras.TabIndex = 4;
            this.lblCodBarras.Text = "Código de Barras";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(7, 55);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(346, 1);
            this.panel8.TabIndex = 5;
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodBarras.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCodBarras.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtCodBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(158)))));
            this.txtCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodBarras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarras.ForeColor = System.Drawing.Color.White;
            this.txtCodBarras.Location = new System.Drawing.Point(7, 35);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(346, 19);
            this.txtCodBarras.TabIndex = 3;
            // 
            // quantidadePanel
            // 
            this.quantidadePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantidadePanel.Controls.Add(this.txtQuantidade);
            this.quantidadePanel.Controls.Add(this.lblQuantidade);
            this.quantidadePanel.Controls.Add(this.panel6);
            this.quantidadePanel.Location = new System.Drawing.Point(752, 3);
            this.quantidadePanel.Name = "quantidadePanel";
            this.quantidadePanel.Size = new System.Drawing.Size(397, 73);
            this.quantidadePanel.TabIndex = 2;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(158)))));
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidade.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.ForeColor = System.Drawing.Color.White;
            this.txtQuantidade.Location = new System.Drawing.Point(7, 33);
            this.txtQuantidade.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(387, 22);
            this.txtQuantidade.TabIndex = 3;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblQuantidade.Location = new System.Drawing.Point(4, 3);
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
            this.panel6.Location = new System.Drawing.Point(7, 55);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(387, 1);
            this.panel6.TabIndex = 5;
            // 
            // precoPanel
            // 
            this.precoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.precoPanel.Controls.Add(this.lblPreco);
            this.precoPanel.Controls.Add(this.panel4);
            this.precoPanel.Controls.Add(this.txtPreco);
            this.precoPanel.Location = new System.Drawing.Point(376, 3);
            this.precoPanel.Name = "precoPanel";
            this.precoPanel.Size = new System.Drawing.Size(370, 73);
            this.precoPanel.TabIndex = 1;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.White;
            this.lblPreco.Location = new System.Drawing.Point(4, 3);
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
            this.panel4.Location = new System.Drawing.Point(7, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(327, 1);
            this.panel4.TabIndex = 5;
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPreco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(158)))));
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreco.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.ForeColor = System.Drawing.Color.White;
            this.txtPreco.Location = new System.Drawing.Point(7, 35);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ShortcutsEnabled = false;
            this.txtPreco.Size = new System.Drawing.Size(327, 19);
            this.txtPreco.TabIndex = 3;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
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
            this.nomeProdutoPanel.Size = new System.Drawing.Size(367, 73);
            this.nomeProdutoPanel.TabIndex = 0;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.ForeColor = System.Drawing.Color.White;
            this.lblNomeProduto.Location = new System.Drawing.Point(4, 3);
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
            this.panel1.Location = new System.Drawing.Point(7, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 1);
            this.panel1.TabIndex = 5;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNomeProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtNomeProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(158)))));
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.ForeColor = System.Drawing.Color.White;
            this.txtNomeProduto.Location = new System.Drawing.Point(7, 35);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(346, 19);
            this.txtNomeProduto.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.Controls.Add(this.btnCadastrar);
            this.panel12.Location = new System.Drawing.Point(376, 472);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(370, 41);
            this.panel12.TabIndex = 8;
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
            this.btnCadastrar.Location = new System.Drawing.Point(8, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(326, 36);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Atualizar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // descricaoPanel
            // 
            this.descricaoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblAtualizar.SetColumnSpan(this.descricaoPanel, 3);
            this.descricaoPanel.Controls.Add(this.txtDescricao);
            this.descricaoPanel.Controls.Add(this.lblDescricao);
            this.descricaoPanel.Location = new System.Drawing.Point(3, 250);
            this.descricaoPanel.Name = "descricaoPanel";
            this.descricaoPanel.Size = new System.Drawing.Size(1146, 216);
            this.descricaoPanel.TabIndex = 7;
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
            this.txtDescricao.Size = new System.Drawing.Size(1137, 190);
            this.txtDescricao.TabIndex = 5;
            this.txtDescricao.Text = "";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(3, 3);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(84, 20);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblCodProduto);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtCodProduto);
            this.panel2.Location = new System.Drawing.Point(752, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 77);
            this.panel2.TabIndex = 6;
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProduto.ForeColor = System.Drawing.Color.White;
            this.lblCodProduto.Location = new System.Drawing.Point(4, 3);
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
            this.panel3.Location = new System.Drawing.Point(7, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 1);
            this.panel3.TabIndex = 5;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCodProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtCodProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(158)))));
            this.txtCodProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProduto.ForeColor = System.Drawing.Color.White;
            this.txtCodProduto.Location = new System.Drawing.Point(7, 35);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(387, 19);
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
            this.localArmazenadoPanel.Location = new System.Drawing.Point(376, 165);
            this.localArmazenadoPanel.Name = "localArmazenadoPanel";
            this.localArmazenadoPanel.Size = new System.Drawing.Size(370, 79);
            this.localArmazenadoPanel.TabIndex = 5;
            // 
            // lblLocalArmazenado
            // 
            this.lblLocalArmazenado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocalArmazenado.AutoSize = true;
            this.lblLocalArmazenado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalArmazenado.ForeColor = System.Drawing.Color.White;
            this.lblLocalArmazenado.Location = new System.Drawing.Point(4, 3);
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
            this.panel10.Location = new System.Drawing.Point(7, 55);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(327, 1);
            this.panel10.TabIndex = 5;
            // 
            // txtLocalArmazenado
            // 
            this.txtLocalArmazenado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocalArmazenado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLocalArmazenado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtLocalArmazenado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(158)))));
            this.txtLocalArmazenado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocalArmazenado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalArmazenado.ForeColor = System.Drawing.Color.White;
            this.txtLocalArmazenado.Location = new System.Drawing.Point(7, 35);
            this.txtLocalArmazenado.Name = "txtLocalArmazenado";
            this.txtLocalArmazenado.Size = new System.Drawing.Size(327, 19);
            this.txtLocalArmazenado.TabIndex = 3;
            // 
            // FrmAtualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(1152, 600);
            this.Controls.Add(this.tblAtualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAtualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar";
            this.Load += new System.EventHandler(this.FrmAtualizar_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.tblAtualizar.ResumeLayout(false);
            this.dataValidadePanel.ResumeLayout(false);
            this.dataValidadePanel.PerformLayout();
            this.codBarrasPanel.ResumeLayout(false);
            this.codBarrasPanel.PerformLayout();
            this.quantidadePanel.ResumeLayout(false);
            this.quantidadePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.precoPanel.ResumeLayout(false);
            this.precoPanel.PerformLayout();
            this.nomeProdutoPanel.ResumeLayout(false);
            this.nomeProdutoPanel.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.descricaoPanel.ResumeLayout(false);
            this.descricaoPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.localArmazenadoPanel.ResumeLayout(false);
            this.localArmazenadoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTopPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tblAtualizar;
        private System.Windows.Forms.Panel dataValidadePanel;
        private System.Windows.Forms.DateTimePicker dtValidade;
        private System.Windows.Forms.Label lblDataValidade;
        private System.Windows.Forms.Panel codBarrasPanel;
        private System.Windows.Forms.Label lblCodBarras;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Panel quantidadePanel;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel precoPanel;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Panel nomeProdutoPanel;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel descricaoPanel;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
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