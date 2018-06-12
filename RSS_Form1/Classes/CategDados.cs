using RSS_Form1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_Form1.Classes
{
    public static class CategDados
    {
        public static int Insert(Categoria oCategoria)
        {
            int QtRes = -1;

            using (var context = new bancoRSS())
            {
                Categoria resCat = context.Categorias
                    .Where(b => b.cat_codigo.Equals(oCategoria.cat_codigo))
                    .FirstOrDefault();

                if (resCat == null)
                {
                    try
                    {
                        context.Categorias.Add(oCategoria);
                        QtRes = context.SaveChanges();
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                    {

                    }
                }
            }

            return QtRes;
        }

        public static List<Categoria> getAll()
        {
            List<Categoria> resCat;

            using (var context = new bancoRSS())
            {
                resCat = context.Categorias.ToList();
            }

            return resCat;
        }

        internal static int Gravar(Categoria oCat)
        {
            int QtRes = -1;

            using (var context = new bancoRSS())
            {
                Categoria resCat = context.Categorias.Find(oCat.cat_codigo);

                if (resCat != null)
                {
                    try
                    {
                        if (!resCat.cat_descricao.Equals(oCat.cat_descricao))
                            resCat.cat_descricao = oCat.cat_descricao;

                        if (!resCat.cat_ordem.Equals(oCat.cat_ordem))
                            resCat.cat_ordem = oCat.cat_ordem;

                        var entry = context.Entry(resCat);

                        QtRes = context.SaveChanges();
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                    {

                    }
                }
            }

            return QtRes;
        }
    }
}
