namespace RSS_Form1.FormsCadastro
{
    partial class FormManutFeeds
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
            this.components = new System.ComponentModel.Container();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ttbOrdem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ttbDescricao = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.ttbCodigo = new System.Windows.Forms.TextBox();
            this.dgvFeeds = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ListaFeedsBS = new System.Windows.Forms.BindingSource(this.components);
            this.feedcodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeddescricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedsiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedurlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedqtnaolidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catcodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedordemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeds)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaFeedsBS)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnIncluir.Location = new System.Drawing.Point(4, 4);
            this.BtnIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(87, 56);
            this.BtnIncluir.TabIndex = 0;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnFechar.Location = new System.Drawing.Point(859, 4);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(87, 56);
            this.BtnFechar.TabIndex = 1;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAlterar.Location = new System.Drawing.Point(99, 4);
            this.BtnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(87, 56);
            this.BtnAlterar.TabIndex = 2;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancelar.Location = new System.Drawing.Point(289, 4);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(87, 56);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.BtnIncluir, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnFechar, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnAlterar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnCancelar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnSalvar, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 532);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 64);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSalvar.Location = new System.Drawing.Point(194, 4);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(87, 56);
            this.BtnSalvar.TabIndex = 4;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ordem:";
            // 
            // ttbOrdem
            // 
            this.ttbOrdem.Enabled = false;
            this.ttbOrdem.Location = new System.Drawing.Point(576, 49);
            this.ttbOrdem.Margin = new System.Windows.Forms.Padding(4);
            this.ttbOrdem.Name = "ttbOrdem";
            this.ttbOrdem.Size = new System.Drawing.Size(73, 30);
            this.ttbOrdem.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrição:";
            // 
            // ttbDescricao
            // 
            this.ttbDescricao.Enabled = false;
            this.ttbDescricao.Location = new System.Drawing.Point(112, 49);
            this.ttbDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.ttbDescricao.Name = "ttbDescricao";
            this.ttbDescricao.Size = new System.Drawing.Size(456, 30);
            this.ttbDescricao.TabIndex = 2;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(23, 20);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(81, 25);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // ttbCodigo
            // 
            this.ttbCodigo.Enabled = false;
            this.ttbCodigo.Location = new System.Drawing.Point(24, 49);
            this.ttbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.ttbCodigo.Name = "ttbCodigo";
            this.ttbCodigo.Size = new System.Drawing.Size(80, 30);
            this.ttbCodigo.TabIndex = 0;
            // 
            // dgvFeeds
            // 
            this.dgvFeeds.AllowUserToAddRows = false;
            this.dgvFeeds.AllowUserToDeleteRows = false;
            this.dgvFeeds.AllowUserToResizeColumns = false;
            this.dgvFeeds.AllowUserToResizeRows = false;
            this.dgvFeeds.AutoGenerateColumns = false;
            this.dgvFeeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeeds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.feedcodigoDataGridViewTextBoxColumn,
            this.feeddescricaoDataGridViewTextBoxColumn,
            this.feedsiteDataGridViewTextBoxColumn,
            this.feedurlDataGridViewTextBoxColumn,
            this.feedqtnaolidosDataGridViewTextBoxColumn,
            this.catcodigoDataGridViewTextBoxColumn,
            this.feedordemDataGridViewTextBoxColumn,
            this.itemsDataGridViewTextBoxColumn,
            this.Categoria});
            this.dgvFeeds.DataSource = this.ListaFeedsBS;
            this.dgvFeeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFeeds.Location = new System.Drawing.Point(13, 12);
            this.dgvFeeds.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFeeds.Name = "dgvFeeds";
            this.dgvFeeds.ReadOnly = true;
            this.dgvFeeds.RowHeadersVisible = false;
            this.dgvFeeds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFeeds.Size = new System.Drawing.Size(924, 392);
            this.dgvFeeds.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvFeeds);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel1.Size = new System.Drawing.Size(950, 532);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ttbOrdem);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ttbDescricao);
            this.panel2.Controls.Add(this.lblCodigo);
            this.panel2.Controls.Add(this.ttbCodigo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(13, 404);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(924, 116);
            this.panel2.TabIndex = 1;
            // 
            // ListaFeedsBS
            // 
            this.ListaFeedsBS.DataSource = typeof(RSS_Form1.Modelos.Feed);
            // 
            // feedcodigoDataGridViewTextBoxColumn
            // 
            this.feedcodigoDataGridViewTextBoxColumn.DataPropertyName = "feed_codigo";
            this.feedcodigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.feedcodigoDataGridViewTextBoxColumn.Name = "feedcodigoDataGridViewTextBoxColumn";
            this.feedcodigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feeddescricaoDataGridViewTextBoxColumn
            // 
            this.feeddescricaoDataGridViewTextBoxColumn.DataPropertyName = "feed_descricao";
            this.feeddescricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.feeddescricaoDataGridViewTextBoxColumn.Name = "feeddescricaoDataGridViewTextBoxColumn";
            this.feeddescricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feedsiteDataGridViewTextBoxColumn
            // 
            this.feedsiteDataGridViewTextBoxColumn.DataPropertyName = "feed_site";
            this.feedsiteDataGridViewTextBoxColumn.HeaderText = "Site";
            this.feedsiteDataGridViewTextBoxColumn.Name = "feedsiteDataGridViewTextBoxColumn";
            this.feedsiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feedurlDataGridViewTextBoxColumn
            // 
            this.feedurlDataGridViewTextBoxColumn.DataPropertyName = "feed_url";
            this.feedurlDataGridViewTextBoxColumn.HeaderText = "feed_url";
            this.feedurlDataGridViewTextBoxColumn.Name = "feedurlDataGridViewTextBoxColumn";
            this.feedurlDataGridViewTextBoxColumn.ReadOnly = true;
            this.feedurlDataGridViewTextBoxColumn.Visible = false;
            // 
            // feedqtnaolidosDataGridViewTextBoxColumn
            // 
            this.feedqtnaolidosDataGridViewTextBoxColumn.DataPropertyName = "feed_qt_nao_lidos";
            this.feedqtnaolidosDataGridViewTextBoxColumn.HeaderText = "feed_qt_nao_lidos";
            this.feedqtnaolidosDataGridViewTextBoxColumn.Name = "feedqtnaolidosDataGridViewTextBoxColumn";
            this.feedqtnaolidosDataGridViewTextBoxColumn.ReadOnly = true;
            this.feedqtnaolidosDataGridViewTextBoxColumn.Visible = false;
            // 
            // catcodigoDataGridViewTextBoxColumn
            // 
            this.catcodigoDataGridViewTextBoxColumn.DataPropertyName = "cat_codigo";
            this.catcodigoDataGridViewTextBoxColumn.HeaderText = "cat_codigo";
            this.catcodigoDataGridViewTextBoxColumn.Name = "catcodigoDataGridViewTextBoxColumn";
            this.catcodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.catcodigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // feedordemDataGridViewTextBoxColumn
            // 
            this.feedordemDataGridViewTextBoxColumn.DataPropertyName = "feed_ordem";
            this.feedordemDataGridViewTextBoxColumn.HeaderText = "Ordem";
            this.feedordemDataGridViewTextBoxColumn.Name = "feedordemDataGridViewTextBoxColumn";
            this.feedordemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemsDataGridViewTextBoxColumn
            // 
            this.itemsDataGridViewTextBoxColumn.DataPropertyName = "Items";
            this.itemsDataGridViewTextBoxColumn.HeaderText = "Items";
            this.itemsDataGridViewTextBoxColumn.Name = "itemsDataGridViewTextBoxColumn";
            this.itemsDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemsDataGridViewTextBoxColumn.Visible = false;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // FormManutFeeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 596);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormManutFeeds";
            this.Text = "FormManutFeeds";
            this.Load += new System.EventHandler(this.FormManutFeed_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeds)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaFeedsBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttbOrdem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttbDescricao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox ttbCodigo;
        private System.Windows.Forms.DataGridView dgvFeeds;
        private System.Windows.Forms.BindingSource ListaFeedsBS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedcodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeddescricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedsiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedurlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedqtnaolidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catcodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedordemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}