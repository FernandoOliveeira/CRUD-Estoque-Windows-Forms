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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.pRODUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTOQUEDataSet = new Sistema_Estoque.ESTOQUEDataSet();
            this.consultarNomePanelLine = new System.Windows.Forms.Panel();
            this.txtConsultarNome = new System.Windows.Forms.TextBox();
            this.rdbConsultarNome = new System.Windows.Forms.RadioButton();
            this.txtConsultarCodigo = new System.Windows.Forms.TextBox();
            this.rdbConsultarCodigo = new System.Windows.Forms.RadioButton();
            this.consultarCodigoPanelLine = new System.Windows.Forms.Panel();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.rdbConsultarCodBarras = new System.Windows.Forms.RadioButton();
            this.consultarCodBarrasPanelLine = new System.Windows.Forms.Panel();
            this.pRODUTOSTableAdapter = new Sistema_Estoque.ESTOQUEDataSetTableAdapters.PRODUTOSTableAdapter();
            this.iDPRODUTOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODBARRASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAVALIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCALARMAZENADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATACADASTRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATUALIZAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EXCLUIR = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTOQUEDataSet)).BeginInit();
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
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Consultar Produtos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.AllowUserToOrderColumns = true;
            this.dgvConsulta.AllowUserToResizeRows = false;
            this.dgvConsulta.AutoGenerateColumns = false;
            this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPRODUTOSDataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn,
            this.pRECODataGridViewTextBoxColumn,
            this.qUANTIDADEDataGridViewTextBoxColumn,
            this.cODBARRASDataGridViewTextBoxColumn,
            this.cODPRODUTODataGridViewTextBoxColumn,
            this.dATAVALIDADEDataGridViewTextBoxColumn,
            this.lOCALARMAZENADODataGridViewTextBoxColumn,
            this.dESCRICAODataGridViewTextBoxColumn,
            this.dATACADASTRODataGridViewTextBoxColumn,
            this.ATUALIZAR,
            this.EXCLUIR});
            this.dgvConsulta.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvConsulta.DataSource = this.pRODUTOSBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsulta.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvConsulta.Location = new System.Drawing.Point(0, 292);
            this.dgvConsulta.MultiSelect = false;
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(166)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsulta.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(745, 221);
            this.dgvConsulta.TabIndex = 0;
            this.dgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellContentClick);
            // 
            // pRODUTOSBindingSource
            // 
            this.pRODUTOSBindingSource.DataMember = "PRODUTOS";
            this.pRODUTOSBindingSource.DataSource = this.eSTOQUEDataSet;
            // 
            // eSTOQUEDataSet
            // 
            this.eSTOQUEDataSet.DataSetName = "ESTOQUEDataSet";
            this.eSTOQUEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultarNomePanelLine
            // 
            this.consultarNomePanelLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consultarNomePanelLine.BackColor = System.Drawing.Color.Black;
            this.consultarNomePanelLine.ForeColor = System.Drawing.Color.Black;
            this.consultarNomePanelLine.Location = new System.Drawing.Point(8, 104);
            this.consultarNomePanelLine.Name = "consultarNomePanelLine";
            this.consultarNomePanelLine.Size = new System.Drawing.Size(191, 1);
            this.consultarNomePanelLine.TabIndex = 2;
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
            this.txtConsultarNome.Location = new System.Drawing.Point(8, 87);
            this.txtConsultarNome.Name = "txtConsultarNome";
            this.txtConsultarNome.Size = new System.Drawing.Size(191, 19);
            this.txtConsultarNome.TabIndex = 1;
            this.txtConsultarNome.TextChanged += new System.EventHandler(this.txtConsultarNome_TextChanged);
            // 
            // rdbConsultarNome
            // 
            this.rdbConsultarNome.AutoSize = true;
            this.rdbConsultarNome.Checked = true;
            this.rdbConsultarNome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbConsultarNome.ForeColor = System.Drawing.Color.White;
            this.rdbConsultarNome.Location = new System.Drawing.Point(7, 66);
            this.rdbConsultarNome.Name = "rdbConsultarNome";
            this.rdbConsultarNome.Size = new System.Drawing.Size(266, 24);
            this.rdbConsultarNome.TabIndex = 0;
            this.rdbConsultarNome.TabStop = true;
            this.rdbConsultarNome.Text = "Consultar pelo nome do produto";
            this.rdbConsultarNome.UseVisualStyleBackColor = true;
            this.rdbConsultarNome.CheckedChanged += new System.EventHandler(this.rdbConsultarNome_CheckedChanged);
            // 
            // txtConsultarCodigo
            // 
            this.txtConsultarCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultarCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtConsultarCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtConsultarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(103)))));
            this.txtConsultarCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsultarCodigo.Enabled = false;
            this.txtConsultarCodigo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultarCodigo.ForeColor = System.Drawing.Color.White;
            this.txtConsultarCodigo.Location = new System.Drawing.Point(8, 156);
            this.txtConsultarCodigo.Name = "txtConsultarCodigo";
            this.txtConsultarCodigo.Size = new System.Drawing.Size(191, 19);
            this.txtConsultarCodigo.TabIndex = 1;
            this.txtConsultarCodigo.TextChanged += new System.EventHandler(this.txtConsultarCodigo_TextChanged);
            // 
            // rdbConsultarCodigo
            // 
            this.rdbConsultarCodigo.AutoSize = true;
            this.rdbConsultarCodigo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbConsultarCodigo.ForeColor = System.Drawing.Color.White;
            this.rdbConsultarCodigo.Location = new System.Drawing.Point(7, 135);
            this.rdbConsultarCodigo.Name = "rdbConsultarCodigo";
            this.rdbConsultarCodigo.Size = new System.Drawing.Size(277, 24);
            this.rdbConsultarCodigo.TabIndex = 0;
            this.rdbConsultarCodigo.TabStop = true;
            this.rdbConsultarCodigo.Text = "Consultar pelo código do produto";
            this.rdbConsultarCodigo.UseVisualStyleBackColor = true;
            this.rdbConsultarCodigo.CheckedChanged += new System.EventHandler(this.rdbConsultarCodigo_CheckedChanged);
            // 
            // consultarCodigoPanelLine
            // 
            this.consultarCodigoPanelLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consultarCodigoPanelLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.consultarCodigoPanelLine.Location = new System.Drawing.Point(8, 173);
            this.consultarCodigoPanelLine.Name = "consultarCodigoPanelLine";
            this.consultarCodigoPanelLine.Size = new System.Drawing.Size(191, 1);
            this.consultarCodigoPanelLine.TabIndex = 3;
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodBarras.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCodBarras.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtCodBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(103)))));
            this.txtCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodBarras.Enabled = false;
            this.txtCodBarras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarras.ForeColor = System.Drawing.Color.White;
            this.txtCodBarras.Location = new System.Drawing.Point(8, 222);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(191, 19);
            this.txtCodBarras.TabIndex = 1;
            this.txtCodBarras.TextChanged += new System.EventHandler(this.txtCodBarras_TextChanged);
            // 
            // rdbConsultarCodBarras
            // 
            this.rdbConsultarCodBarras.AutoSize = true;
            this.rdbConsultarCodBarras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbConsultarCodBarras.ForeColor = System.Drawing.Color.White;
            this.rdbConsultarCodBarras.Location = new System.Drawing.Point(7, 201);
            this.rdbConsultarCodBarras.Name = "rdbConsultarCodBarras";
            this.rdbConsultarCodBarras.Size = new System.Drawing.Size(264, 24);
            this.rdbConsultarCodBarras.TabIndex = 0;
            this.rdbConsultarCodBarras.TabStop = true;
            this.rdbConsultarCodBarras.Text = "Consultar pelo código de barras";
            this.rdbConsultarCodBarras.UseVisualStyleBackColor = true;
            this.rdbConsultarCodBarras.CheckedChanged += new System.EventHandler(this.rdbConsultarCodBarras_CheckedChanged);
            // 
            // consultarCodBarrasPanelLine
            // 
            this.consultarCodBarrasPanelLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consultarCodBarrasPanelLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.consultarCodBarrasPanelLine.Location = new System.Drawing.Point(8, 239);
            this.consultarCodBarrasPanelLine.Name = "consultarCodBarrasPanelLine";
            this.consultarCodBarrasPanelLine.Size = new System.Drawing.Size(191, 1);
            this.consultarCodBarrasPanelLine.TabIndex = 4;
            // 
            // pRODUTOSTableAdapter
            // 
            this.pRODUTOSTableAdapter.ClearBeforeFill = true;
            // 
            // iDPRODUTOSDataGridViewTextBoxColumn
            // 
            this.iDPRODUTOSDataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUTOS";
            this.iDPRODUTOSDataGridViewTextBoxColumn.HeaderText = "ID_PRODUTOS";
            this.iDPRODUTOSDataGridViewTextBoxColumn.Name = "iDPRODUTOSDataGridViewTextBoxColumn";
            this.iDPRODUTOSDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPRODUTOSDataGridViewTextBoxColumn.Visible = false;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            this.nOMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRECODataGridViewTextBoxColumn
            // 
            this.pRECODataGridViewTextBoxColumn.DataPropertyName = "PRECO";
            this.pRECODataGridViewTextBoxColumn.HeaderText = "PRECO";
            this.pRECODataGridViewTextBoxColumn.Name = "pRECODataGridViewTextBoxColumn";
            this.pRECODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qUANTIDADEDataGridViewTextBoxColumn
            // 
            this.qUANTIDADEDataGridViewTextBoxColumn.DataPropertyName = "QUANTIDADE";
            this.qUANTIDADEDataGridViewTextBoxColumn.HeaderText = "QUANTIDADE";
            this.qUANTIDADEDataGridViewTextBoxColumn.Name = "qUANTIDADEDataGridViewTextBoxColumn";
            this.qUANTIDADEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cODBARRASDataGridViewTextBoxColumn
            // 
            this.cODBARRASDataGridViewTextBoxColumn.DataPropertyName = "COD_BARRAS";
            this.cODBARRASDataGridViewTextBoxColumn.HeaderText = "CÓD. BARRAS";
            this.cODBARRASDataGridViewTextBoxColumn.Name = "cODBARRASDataGridViewTextBoxColumn";
            this.cODBARRASDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cODPRODUTODataGridViewTextBoxColumn
            // 
            this.cODPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_PRODUTO";
            this.cODPRODUTODataGridViewTextBoxColumn.HeaderText = "CÓD. PRODUTO";
            this.cODPRODUTODataGridViewTextBoxColumn.Name = "cODPRODUTODataGridViewTextBoxColumn";
            this.cODPRODUTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATAVALIDADEDataGridViewTextBoxColumn
            // 
            this.dATAVALIDADEDataGridViewTextBoxColumn.DataPropertyName = "DATA_VALIDADE";
            this.dATAVALIDADEDataGridViewTextBoxColumn.HeaderText = "DATA DE VALIDADE";
            this.dATAVALIDADEDataGridViewTextBoxColumn.Name = "dATAVALIDADEDataGridViewTextBoxColumn";
            this.dATAVALIDADEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lOCALARMAZENADODataGridViewTextBoxColumn
            // 
            this.lOCALARMAZENADODataGridViewTextBoxColumn.DataPropertyName = "LOCAL_ARMAZENADO";
            this.lOCALARMAZENADODataGridViewTextBoxColumn.HeaderText = "LOCAL ARMAZENADO";
            this.lOCALARMAZENADODataGridViewTextBoxColumn.Name = "lOCALARMAZENADODataGridViewTextBoxColumn";
            this.lOCALARMAZENADODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRICAODataGridViewTextBoxColumn
            // 
            this.dESCRICAODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO";
            this.dESCRICAODataGridViewTextBoxColumn.HeaderText = "DESCRICAO";
            this.dESCRICAODataGridViewTextBoxColumn.Name = "dESCRICAODataGridViewTextBoxColumn";
            this.dESCRICAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATACADASTRODataGridViewTextBoxColumn
            // 
            this.dATACADASTRODataGridViewTextBoxColumn.DataPropertyName = "DATA_CADASTRO";
            this.dATACADASTRODataGridViewTextBoxColumn.HeaderText = "DATA DE CADASTRO";
            this.dATACADASTRODataGridViewTextBoxColumn.Name = "dATACADASTRODataGridViewTextBoxColumn";
            this.dATACADASTRODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ATUALIZAR
            // 
            this.ATUALIZAR.DataPropertyName = "ATUALIZAR";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.ATUALIZAR.DefaultCellStyle = dataGridViewCellStyle2;
            this.ATUALIZAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ATUALIZAR.HeaderText = "ATUALIZAR";
            this.ATUALIZAR.Name = "ATUALIZAR";
            this.ATUALIZAR.ReadOnly = true;
            this.ATUALIZAR.Text = "ATUALIZAR";
            this.ATUALIZAR.UseColumnTextForButtonValue = true;
            // 
            // EXCLUIR
            // 
            this.EXCLUIR.DataPropertyName = "EXCLUIR";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.EXCLUIR.DefaultCellStyle = dataGridViewCellStyle3;
            this.EXCLUIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXCLUIR.HeaderText = "EXCLUIR";
            this.EXCLUIR.Name = "EXCLUIR";
            this.EXCLUIR.ReadOnly = true;
            this.EXCLUIR.Text = "EXCLUIR";
            this.EXCLUIR.UseColumnTextForButtonValue = true;
            // 
            // UCConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.consultarNomePanelLine);
            this.Controls.Add(this.rdbConsultarCodBarras);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtConsultarCodigo);
            this.Controls.Add(this.rdbConsultarNome);
            this.Controls.Add(this.consultarCodBarrasPanelLine);
            this.Controls.Add(this.rdbConsultarCodigo);
            this.Controls.Add(this.txtConsultarNome);
            this.Controls.Add(this.txtCodBarras);
            this.Controls.Add(this.consultarCodigoPanelLine);
            this.Name = "UCConsultar";
            this.Size = new System.Drawing.Size(745, 513);
            this.Load += new System.EventHandler(this.UCConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTOQUEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Panel consultarNomePanelLine;
        private System.Windows.Forms.TextBox txtConsultarNome;
        private System.Windows.Forms.RadioButton rdbConsultarNome;
        private System.Windows.Forms.RadioButton rdbConsultarCodigo;
        private System.Windows.Forms.TextBox txtConsultarCodigo;
        private System.Windows.Forms.Panel consultarCodigoPanelLine;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.RadioButton rdbConsultarCodBarras;
        private System.Windows.Forms.Panel consultarCodBarrasPanelLine;
        private System.Windows.Forms.BindingSource pRODUTOSBindingSource;
        private ESTOQUEDataSet eSTOQUEDataSet;
        private ESTOQUEDataSetTableAdapters.PRODUTOSTableAdapter pRODUTOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUTOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODBARRASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAVALIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCALARMAZENADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATACADASTRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ATUALIZAR;
        private System.Windows.Forms.DataGridViewButtonColumn EXCLUIR;
    }
}
