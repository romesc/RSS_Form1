using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSS_Form1.FormsCadastro
{
    public partial class FormWeb : Form
    {
        private string sConteudo;

        public FormWeb(string pConteudo)
        {
            InitializeComponent();
            this.sConteudo = pConteudo;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            wbVisualizador.Refresh();
            //this.Dispose();
            //this.Close();
        }

        private void FormWeb_Load(object sender, EventArgs e)
        {
            wbVisualizador.DocumentText = sConteudo;
            //wbVisualizador.Refresh();
        }
    }
}
