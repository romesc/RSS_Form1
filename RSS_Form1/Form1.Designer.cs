namespace RSS_Form1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.itemtituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemconteudoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdthrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemlidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.feedcodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemurlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.feedsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tvFeeds = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAtualiza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToResizeRows = false;
            this.dgvItens.AutoGenerateColumns = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemtituloDataGridViewTextBoxColumn,
            this.itemconteudoDataGridViewTextBoxColumn,
            this.itemdthrDataGridViewTextBoxColumn,
            this.itemlidoDataGridViewTextBoxColumn,
            this.feedcodigoDataGridViewTextBoxColumn,
            this.itemcodigoDataGridViewTextBoxColumn,
            this.itemurlDataGridViewTextBoxColumn,
            this.feedDataGridViewTextBoxColumn});
            this.dgvItens.DataSource = this.itemBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItens.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItens.Location = new System.Drawing.Point(0, 0);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(968, 605);
            this.dgvItens.TabIndex = 0;
            // 
            // itemtituloDataGridViewTextBoxColumn
            // 
            this.itemtituloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemtituloDataGridViewTextBoxColumn.DataPropertyName = "item_titulo";
            this.itemtituloDataGridViewTextBoxColumn.HeaderText = "Título";
            this.itemtituloDataGridViewTextBoxColumn.Name = "itemtituloDataGridViewTextBoxColumn";
            this.itemtituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemconteudoDataGridViewTextBoxColumn
            // 
            this.itemconteudoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemconteudoDataGridViewTextBoxColumn.DataPropertyName = "item_conteudo";
            this.itemconteudoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.itemconteudoDataGridViewTextBoxColumn.Name = "itemconteudoDataGridViewTextBoxColumn";
            this.itemconteudoDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemconteudoDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemdthrDataGridViewTextBoxColumn
            // 
            this.itemdthrDataGridViewTextBoxColumn.DataPropertyName = "item_dthr";
            this.itemdthrDataGridViewTextBoxColumn.HeaderText = "Publicação";
            this.itemdthrDataGridViewTextBoxColumn.Name = "itemdthrDataGridViewTextBoxColumn";
            this.itemdthrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemlidoDataGridViewTextBoxColumn
            // 
            this.itemlidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.itemlidoDataGridViewTextBoxColumn.DataPropertyName = "item_lido";
            this.itemlidoDataGridViewTextBoxColumn.HeaderText = "Lido?";
            this.itemlidoDataGridViewTextBoxColumn.Name = "itemlidoDataGridViewTextBoxColumn";
            this.itemlidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemlidoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemlidoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemlidoDataGridViewTextBoxColumn.Width = 58;
            // 
            // feedcodigoDataGridViewTextBoxColumn
            // 
            this.feedcodigoDataGridViewTextBoxColumn.DataPropertyName = "feed_codigo";
            this.feedcodigoDataGridViewTextBoxColumn.HeaderText = "feed_codigo";
            this.feedcodigoDataGridViewTextBoxColumn.Name = "feedcodigoDataGridViewTextBoxColumn";
            this.feedcodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.feedcodigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemcodigoDataGridViewTextBoxColumn
            // 
            this.itemcodigoDataGridViewTextBoxColumn.DataPropertyName = "item_codigo";
            this.itemcodigoDataGridViewTextBoxColumn.HeaderText = "item_codigo";
            this.itemcodigoDataGridViewTextBoxColumn.Name = "itemcodigoDataGridViewTextBoxColumn";
            this.itemcodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemcodigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemurlDataGridViewTextBoxColumn
            // 
            this.itemurlDataGridViewTextBoxColumn.DataPropertyName = "item_url";
            this.itemurlDataGridViewTextBoxColumn.HeaderText = "item_url";
            this.itemurlDataGridViewTextBoxColumn.Name = "itemurlDataGridViewTextBoxColumn";
            this.itemurlDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemurlDataGridViewTextBoxColumn.Visible = false;
            // 
            // feedDataGridViewTextBoxColumn
            // 
            this.feedDataGridViewTextBoxColumn.DataPropertyName = "Feed";
            this.feedDataGridViewTextBoxColumn.HeaderText = "Feed";
            this.feedDataGridViewTextBoxColumn.Name = "feedDataGridViewTextBoxColumn";
            this.feedDataGridViewTextBoxColumn.ReadOnly = true;
            this.feedDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(RSS_Form1.Modelos.Item);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feedsToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.regrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1157, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // feedsToolStripMenuItem
            // 
            this.feedsToolStripMenuItem.Name = "feedsToolStripMenuItem";
            this.feedsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.feedsToolStripMenuItem.Text = "Feeds";
            this.feedsToolStripMenuItem.Click += new System.EventHandler(this.feedsToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // regrasToolStripMenuItem
            // 
            this.regrasToolStripMenuItem.Name = "regrasToolStripMenuItem";
            this.regrasToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.regrasToolStripMenuItem.Text = "Regras";
            this.regrasToolStripMenuItem.Click += new System.EventHandler(this.regrasToolStripMenuItem_Click);
            // 
            // tvFeeds
            // 
            this.tvFeeds.BackColor = System.Drawing.Color.Black;
            this.tvFeeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFeeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvFeeds.ForeColor = System.Drawing.Color.LightGray;
            this.tvFeeds.HideSelection = false;
            this.tvFeeds.Location = new System.Drawing.Point(0, 0);
            this.tvFeeds.Margin = new System.Windows.Forms.Padding(10);
            this.tvFeeds.Name = "tvFeeds";
            this.tvFeeds.Size = new System.Drawing.Size(182, 605);
            this.tvFeeds.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAtualiza);
            this.splitContainer1.Panel1.Controls.Add(this.tvFeeds);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvItens);
            this.splitContainer1.Size = new System.Drawing.Size(1157, 605);
            this.splitContainer1.SplitterDistance = 182;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAtualiza.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAtualiza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAtualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualiza.Location = new System.Drawing.Point(0, 562);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(182, 43);
            this.btnAtualiza.TabIndex = 3;
            this.btnAtualiza.Text = "Atualizar";
            this.btnAtualiza.UseVisualStyleBackColor = false;
            this.btnAtualiza.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1157, 629);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSS_Murk";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TreeView tvFeeds;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemtituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemconteudoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdthrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn itemlidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedcodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemurlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedDataGridViewTextBoxColumn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAtualiza;
        private System.Windows.Forms.ToolStripMenuItem feedsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regrasToolStripMenuItem;
    }
}

