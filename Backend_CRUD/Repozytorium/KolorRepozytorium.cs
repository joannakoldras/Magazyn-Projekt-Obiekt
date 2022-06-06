using Backend_CRUD.DB_Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend_CRUD.Repozytorium
{
    public class KolorRepozytorium : IKolorRepozytorium
    {
        private MagazynDbContext dbContext;

        public KolorRepozytorium()
        {
            dbContext = new MagazynDbContext();
        }

        public Kolor GetById(int id)
        {
            Kolor result = null;

            result = dbContext.Kolory.Find(id);

            return result;
        }

        public IEnumerable<Kolor> GetAll()
        {
            List<Kolor> results = new List<Kolor>();

            using (var dbContext = new MagazynDbContext())
            {
                results = dbContext.Kolory.OrderBy(x => x.Id).ToList();
            }
            return results;
        }

        public void Add(object color)
        {
            var rzutowanyKolor = (Kolor)color;

            using (var dbContext = new MagazynDbContext())
            {

                var kolordoPrzekazania = new Kolor()
                {
                    NazwaKoloru = rzutowanyKolor.NazwaKoloru
                };

                dbContext.Kolory.Add(kolordoPrzekazania);
                dbContext.SaveChanges();
            }
        }

        public void Remove(int colorId)
        {
            var kolorDoUsuniecia = GetById(colorId);

            if (kolorDoUsuniecia != null)
            {
                dbContext.Kolory.Remove(kolorDoUsuniecia);
                dbContext.SaveChanges();
            }
        }

        public void Update(object color)
        {
            var rzutowanyKolor = (Kolor)color;
            using (var dbContext = new MagazynDbContext())
            {
                var znalezionyKolor = dbContext.Kolory.Find(rzutowanyKolor.Id);

                if (znalezionyKolor != null)
                {
                    znalezionyKolor.NazwaKoloru = rzutowanyKolor.NazwaKoloru;
                    dbContext.SaveChanges();
                }
            }
        }
    }
}

