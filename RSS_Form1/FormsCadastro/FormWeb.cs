using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using ReadSharp;

namespace RSS_Form1.FormsCadastro
{
    public partial class FormWeb : Form
    {
        private string sUrl;

        public FormWeb(string pConteudo)
        {
            InitializeComponent();
            this.sUrl = pConteudo;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            carregaAsync();
        }

        private async System.Threading.Tasks.Task carregaAsync()
        {
            Reader reader = new Reader();
            Article article;

            try
            {
                article = await reader.Read(new Uri(sUrl));
                var s = article.Images;
                int cont = 0;

                pb1.Maximum = 0;
                foreach (ArticleImage i in s)
                    pb1.Maximum++;

                foreach (ArticleImage i in s)
                {
                    cont++;

                    pb1.Value = cont;
                    pb1.PerformStep();

                    flow1.Controls.Add(new PictureBox() { Name = "pb" + cont.ToString(), Height = 90, Width = 90, SizeMode = PictureBoxSizeMode.AutoSize });
                    ((PictureBox)flow1.Controls[cont - 1]).Load(i.Uri.AbsoluteUri);

                    //if (cont == 30)
                    //    break;
                }

                //wbVisualizador.DocumentText = article.Content;
                flow1.Focus();
            }
            catch (ReadException exc)
            {
                // handle exception
            }
        }

        private void FormWeb_Load(object sender, EventArgs e)
        {
            carregaAsync();
        }
    }
}
