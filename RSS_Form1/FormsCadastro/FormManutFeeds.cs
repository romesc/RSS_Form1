using RSS_Form1.Classes;
using RSS_Form1.Modelos;
using System;
using System.Windows.Forms;

namespace RSS_Form1.FormsCadastro
{
    public partial class FormManutFeeds : Form
    {
        private static Feed oFeedTela = new Feed();

        public FormManutFeeds()
        {
            InitializeComponent();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            oFeedTela = null;
            ttbCodigo.Clear();
            ttbDescricao.Clear();
            ttbOrdem.Clear();
            //CategoriaBS.Clear();
            //CategoriaBS.AddNew();

            Modo("edicao");
        }

        private void Modo(string v)
        {
            switch (v)
            {
                case "nada":
                    ttbDescricao.Enabled = false;
                    ttbOrdem.Enabled = false;
                    BtnIncluir.Enabled = true;
                    BtnAlterar.Enabled = false;
                    BtnSalvar.Enabled = false;
                    BtnCancelar.Enabled = false;
                    BtnFechar.Enabled = true;
                    break;
                case "edicao":
                    ttbDescricao.Enabled = true;
                    ttbOrdem.Enabled = true;
                    BtnIncluir.Enabled = false;
                    BtnAlterar.Enabled = false;
                    BtnSalvar.Enabled = true;
                    BtnCancelar.Enabled = true;
                    BtnFechar.Enabled = false;
                    break;
                case "visualizacao":
                    ttbDescricao.Enabled = false;
                    ttbOrdem.Enabled = false;
                    BtnIncluir.Enabled = true;
                    BtnAlterar.Enabled = true;
                    BtnSalvar.Enabled = false;
                    BtnCancelar.Enabled = false;
                    BtnFechar.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Modo("edicao");
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (oFeedTela == null) // inclusão
            {
                oFeedTela = new Feed
                {
                    feed_descricao = ttbDescricao.Text,
                    feed_ordem = int.Parse(ttbOrdem.Text)
                };

                FeedDados.Insert(oFeedTela);
            }
            else // edição
            {
                oFeedTela.feed_descricao = ttbDescricao.Text;
                oFeedTela.feed_ordem = int.Parse(ttbOrdem.Text);

                FeedDados.Gravar(oFeedTela);
            }

            ListaFeedsBS.Clear();
            ListaFeedsBS.DataSource = FeedDados.getAll();

            Modo("visualizacao");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //CategoriaBS.CancelEdit();
            //CategoriaBS.DataSource = (Categoria)dgvCateg.CurrentRow.DataBoundItem;

            Modo("visualizacao");
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void FormManutFeed_Load(object sender, EventArgs e)
        {
            ListaFeedsBS.DataSource = FeedDados.getAll();

            Modo("nada");
        }

        private void dgvFeed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFeeds.CurrentRow != null)
            {
                oFeedTela = (Feed)dgvFeeds.CurrentRow.DataBoundItem;
                ttbCodigo.Text = oFeedTela.cat_codigo.ToString();
                ttbDescricao.Text = oFeedTela.feed_descricao;
                ttbOrdem.Text = oFeedTela.feed_ordem.ToString();

                //CategoriaBS.DataSource = (Categoria)dgvCateg.CurrentRow.DataBoundItem;

                Modo("visualizacao");
            }
        }
    }
}
