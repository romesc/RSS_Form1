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
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tvFeeds = new System.Windows.Forms.TreeView();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemtituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemconteudoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdthrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemlidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.feedcodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemurlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
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
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItens.Location = new System.Drawing.Point(195, 24);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.Size = new System.Drawing.Size(962, 605);
            this.dgvItens.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1157, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tvFeeds
            // 
            this.tvFeeds.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvFeeds.Location = new System.Drawing.Point(0, 24);
            this.tvFeeds.Name = "tvFeeds";
            this.tvFeeds.Size = new System.Drawing.Size(195, 605);
            this.tvFeeds.TabIndex = 2;
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriasToolStripMenuItem,
            this.feedsToolStripMenuItem,
            this.filtrosToolStripMenuItem});
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // feedsToolStripMenuItem
            // 
            this.feedsToolStripMenuItem.Name = "feedsToolStripMenuItem";
            this.feedsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.feedsToolStripMenuItem.Text = "Feeds";
            // 
            // filtrosToolStripMenuItem
            // 
            this.filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filtrosToolStripMenuItem.Text = "Filtros";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(RSS_Form1.Modelos.Item);
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
            this.itemlidoDataGridViewTextBoxColumn.DataPropertyName = "item_lido";
            this.itemlidoDataGridViewTextBoxColumn.HeaderText = "Lido?";
            this.itemlidoDataGridViewTextBoxColumn.Name = "itemlidoDataGridViewTextBoxColumn";
            this.itemlidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemlidoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemlidoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 629);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.tvFeeds);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSS_Murk";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TreeView tvFeeds;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrosToolStripMenuItem;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemtituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemconteudoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdthrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn itemlidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedcodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemurlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedDataGridViewTextBoxColumn;
    }
}

