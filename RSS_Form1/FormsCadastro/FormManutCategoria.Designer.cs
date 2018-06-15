namespace RSS_Form1.FormsCadastro
{
    partial class FormManutCategoria
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCateg = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.ttbCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ttbDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ttbOrdem = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.catcodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catdescricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catordemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListaGategoriasBS = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCateg)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaGategoriasBS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCateg);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel1.Size = new System.Drawing.Size(897, 490);
            this.panel1.TabIndex = 0;
            // 
            // dgvCateg
            // 
            this.dgvCateg.AllowUserToAddRows = false;
            this.dgvCateg.AllowUserToDeleteRows = false;
            this.dgvCateg.AllowUserToResizeColumns = false;
            this.dgvCateg.AllowUserToResizeRows = false;
            this.dgvCateg.AutoGenerateColumns = false;
            this.dgvCateg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCateg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catcodigoDataGridViewTextBoxColumn,
            this.catdescricaoDataGridViewTextBoxColumn,
            this.catordemDataGridViewTextBoxColumn,
            this.feedsDataGridViewTextBoxColumn});
            this.dgvCateg.DataSource = this.ListaGategoriasBS;
            this.dgvCateg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCateg.Location = new System.Drawing.Point(13, 12);
            this.dgvCateg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCateg.Name = "dgvCateg";
            this.dgvCateg.ReadOnly = true;
            this.dgvCateg.RowHeadersVisible = false;
            this.dgvCateg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCateg.Size = new System.Drawing.Size(871, 350);
            this.dgvCateg.TabIndex = 0;
            this.dgvCateg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCateg_CellClick);
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
            this.panel2.Location = new System.Drawing.Point(13, 362);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(871, 116);
            this.panel2.TabIndex = 1;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 490);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(897, 64);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnIncluir.Location = new System.Drawing.Point(4, 4);
            this.BtnIncluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(81, 56);
            this.BtnIncluir.TabIndex = 0;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnFechar.Location = new System.Drawing.Point(805, 4);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(88, 56);
            this.BtnFechar.TabIndex = 1;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAlterar.Location = new System.Drawing.Point(93, 4);
            this.BtnAlterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(81, 56);
            this.BtnAlterar.TabIndex = 2;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancelar.Location = new System.Drawing.Point(271, 4);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(81, 56);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSalvar.Location = new System.Drawing.Point(182, 4);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(81, 56);
            this.BtnSalvar.TabIndex = 4;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // ttbCodigo
            // 
            this.ttbCodigo.Enabled = false;
            this.ttbCodigo.Location = new System.Drawing.Point(24, 49);
            this.ttbCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ttbCodigo.Name = "ttbCodigo";
            this.ttbCodigo.Size = new System.Drawing.Size(80, 30);
            this.ttbCodigo.TabIndex = 0;
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
            // catcodigoDataGridViewTextBoxColumn
            // 
            this.catcodigoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.catcodigoDataGridViewTextBoxColumn.DataPropertyName = "cat_codigo";
            this.catcodigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.catcodigoDataGridViewTextBoxColumn.Name = "catcodigoDataGridViewTextBoxColumn";
            this.catcodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.catcodigoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.catcodigoDataGridViewTextBoxColumn.Width = 58;
            // 
            // catdescricaoDataGridViewTextBoxColumn
            // 
            this.catdescricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.catdescricaoDataGridViewTextBoxColumn.DataPropertyName = "cat_descricao";
            this.catdescricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.catdescricaoDataGridViewTextBoxColumn.Name = "catdescricaoDataGridViewTextBoxColumn";
            this.catdescricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.catdescricaoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // catordemDataGridViewTextBoxColumn
            // 
            this.catordemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.catordemDataGridViewTextBoxColumn.DataPropertyName = "cat_ordem";
            this.catordemDataGridViewTextBoxColumn.HeaderText = "Ordem";
            this.catordemDataGridViewTextBoxColumn.Name = "catordemDataGridViewTextBoxColumn";
            this.catordemDataGridViewTextBoxColumn.ReadOnly = true;
            this.catordemDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.catordemDataGridViewTextBoxColumn.Width = 57;
            // 
            // feedsDataGridViewTextBoxColumn
            // 
            this.feedsDataGridViewTextBoxColumn.DataPropertyName = "Feeds";
            this.feedsDataGridViewTextBoxColumn.HeaderText = "Feeds";
            this.feedsDataGridViewTextBoxColumn.Name = "feedsDataGridViewTextBoxColumn";
            this.feedsDataGridViewTextBoxColumn.ReadOnly = true;
            this.feedsDataGridViewTextBoxColumn.Visible = false;
            // 
            // ListaGategoriasBS
            // 
            this.ListaGategoriasBS.DataSource = typeof(RSS_Form1.Modelos.Categoria);
            // 
            // FormManutCategoria
            // 
            this.AcceptButton = this.BtnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(897, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormManutCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manutenção Categorias";
            this.Load += new System.EventHandler(this.FormManutCategoria_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCateg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaGategoriasBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn catcodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catdescricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catordemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ListaGategoriasBS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttbDescricao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox ttbCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttbOrdem;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}