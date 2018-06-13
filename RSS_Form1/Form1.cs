using RSS_Form1.Classes;
using RSS_Form1.Modelos;
using SimpleFeedReader;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RSS_Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregaCategorias();
        }

        private void CarregaFeeds()
        {
            var reader = new FeedReader();
            var items = reader.RetrieveFeed("https://iplusall.com/feed/");

            List<Item> oItens = new List<Item>();

            Item oItem = new Item();

            foreach (var i in items)
            {
                oItem = new Item
                {
                    item_titulo = i.Title,
                    item_url = i.Uri.ToString(),
                    item_dthr = i.Date.LocalDateTime,
                    item_conteudo = i.Content
                };

                oItens.Add(oItem);
            }

            itemBindingSource.DataSource = oItens;
        }

        private void CarregaCategorias()
        {
            string kCat = "";
            string kFeed = "";

            var lCategorias = CategDados.getAll();
            var lFeeds = FeedDados.getAll();
            var lItens = ItemDados.retornaNaoLidos();

            foreach (Categoria catAux in lCategorias)
            {
                kCat = "cat|" + catAux.cat_codigo.ToString();

                tvFeeds.Nodes.Add(kCat, catAux.cat_descricao);

                foreach (Feed fdAux in lFeeds.Where(b => b.cat_codigo.Equals(catAux.cat_codigo)).ToList())
                {
                    kFeed = "feed|" + fdAux.feed_codigo.ToString();

                    tvFeeds.Nodes[kCat].Nodes.Add(kFeed, fdAux.feed_descricao.TrimEnd());
                }
            }

            tvFeeds.ExpandAll();
        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            CarregaFeeds();
        }
    }
}
