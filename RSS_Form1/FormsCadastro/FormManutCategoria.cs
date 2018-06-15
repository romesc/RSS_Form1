using RSS_Form1.Classes;
using RSS_Form1.Modelos;
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
    public partial class FormManutCategoria : Form
    {
        public FormManutCategoria()
        {
            InitializeComponent();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            CategoriaBS.Clear();
            CategoriaBS.AddNew();

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
            CategoriaBS.EndEdit();
            CategDados.Insert((Categoria)CategoriaBS.Current);

            Modo("visualizacao");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CategoriaBS.CancelEdit();
            CategoriaBS.DataSource = (Categoria)dgvCateg.CurrentRow.DataBoundItem;

            Modo("visualizacao");
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void FormManutCategoria_Load(object sender, EventArgs e)
        {
            ListaGategoriasBS.DataSource = CategDados.getAll();

            Modo("nada");
        }

        private void dgvCateg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCateg.CurrentRow != null)
            {
                CategoriaBS.DataSource = (Categoria)dgvCateg.CurrentRow.DataBoundItem;

                Modo("visualizacao");
            }
        }
    }
}
