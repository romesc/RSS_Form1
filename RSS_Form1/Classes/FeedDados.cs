﻿using RSS_Form1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_Form1.Classes
{
    public static class FeedDados
    {
        public static int Insert(Feed oFeed)
        {
            int QtRes = -1;

            using (var context = new bancoRSS())
            {
                Feed resFeed = context.Feeds
                    .Where(b => b.feed_codigo.Equals(oFeed.feed_codigo))
                    .FirstOrDefault();

                if (resFeed == null)
                {
                    try
                    {
                        context.Feeds.Add(oFeed);
                        QtRes = context.SaveChanges();
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                    {

                    }
                }
            }

            return QtRes;
        }

        public static Feed getFeedByCodigo(int codigo)
        {
            Feed resFeed;

            using (var context = new bancoRSS())
            {
                resFeed = context.Feeds.Where(b => b.feed_codigo.Equals(codigo)).FirstOrDefault();
            }

            return resFeed;
        }

        public static List<Feed> getAll()
        {
            List<Feed> resFeed;

            using (var context = new bancoRSS())
            {
                resFeed = context.Feeds.OrderBy(b => b.feed_ordem).ToList();
            }

            if (resFeed.Count >= 0)
            {
                foreach (Feed oF in resFeed)
                {
                    oF.Categoria = CategDados.getCategByCodigo(oF.cat_codigo);
                }
            }

            return resFeed;
        }

        internal static int Gravar(Feed oFeed)
        {
            int QtRes = -1;

            using (var context = new bancoRSS())
            {
                Feed resFeed = context.Feeds.Find(oFeed.feed_codigo);

                if (resFeed != null)
                {
                    try
                    {
                        if (!resFeed.feed_descricao.Equals(oFeed.feed_descricao))
                            resFeed.feed_descricao = oFeed.feed_descricao;

                        if (!resFeed.feed_ordem.Equals(oFeed.feed_ordem))
                            resFeed.feed_ordem = oFeed.feed_ordem;

                        var entry = context.Entry(resFeed);

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
