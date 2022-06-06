using Backend_CRUD.DB_Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend_CRUD.Repozytorium
{
    public class KategoriaRepozytrium : IKategoriaRepozytorium
    {
        private MagazynDbContext dbContext;

        public KategoriaRepozytrium()
        {
            dbContext = new MagazynDbContext();
        }

        public Kategoria GetById(int id)
        {
            Kategoria wynik = null;

            wynik = dbContext.Kategorie.Find(id);

            return wynik;
        }

        public IEnumerable<Kategoria> GetAll()
        {
            List<Kategoria> wyniki = new List<Kategoria>();

            using (var dbContext = new MagazynDbContext())
            {

                wyniki = dbContext.Kategorie.OrderBy(x => x.Id).ToList();
            }
            return wyniki;
        }

        public void Add(object category)
        {
            var rzutowanaKategoria = (Kategoria)category;

            using (var dbContext = new MagazynDbContext())
            {

                var categoryToPass = new Kategoria()
                {
                    NazwaKategorii = rzutowanaKategoria.NazwaKategorii
                };

                dbContext.Kategorie.Add(categoryToPass);
                dbContext.SaveChanges();
            }
        }

        public void Remove(int categoryId)
        {
            var kategoriaDoUsuniecia = GetById(categoryId);

            if (kategoriaDoUsuniecia != null)
            {
                dbContext.Kategorie.Remove(kategoriaDoUsuniecia);
                dbContext.SaveChanges();
            }
        }

        public void Update(object category)
        {
            var rzutowanaKategoria = (Kategoria)category;
            using (var dbContext = new MagazynDbContext())
            {
                var findedCateogry = dbContext.Kategorie.Find(rzutowanaKategoria.Id);

                if (findedCateogry != null)
                {
                    findedCateogry.NazwaKategorii = rzutowanaKategoria.NazwaKategorii;

                    dbContext.SaveChanges();
                }
            }
        }
    }
}
