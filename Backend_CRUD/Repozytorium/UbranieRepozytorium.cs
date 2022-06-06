using Backend_CRUD.DB_Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend_CRUD.Repozytorium
{
    public class UbranieRepozytorium : IUbranieRepozytorium
    {
        private MagazynDbContext dbContext;
        public UbranieRepozytorium()
        {
            dbContext = new MagazynDbContext();
        }

        public Ubranie GetById(int id)
        {
            Ubranie wynik = null;

            wynik = dbContext.Ubrania.Find(id);

            return wynik;
        }

        public IEnumerable<Ubranie> GetAll()
        {
            List<Ubranie> results = new List<Ubranie>();

            results = dbContext.Ubrania.OrderBy(x => x.NazwaUbrania).ToList();

            return results;
        }

        public void Add(object clothes)
        {
            var rzutowaneUbranie = (Ubranie)clothes;
            var ubranieDoZapisania = new Ubranie()
            {
                IdKategorii = rzutowaneUbranie.IdKategorii,
                IdMarki = rzutowaneUbranie.IdMarki,
                IdKoloru = rzutowaneUbranie.IdKoloru,
                NazwaUbrania = rzutowaneUbranie.NazwaUbrania,
                Cena = rzutowaneUbranie.Cena,
                Ilosc = rzutowaneUbranie.Ilosc
            };

            dbContext.Ubrania.Add(ubranieDoZapisania);
            dbContext.SaveChanges();
        }

        public void Remove(int clotheId)
        {
            var ubranieDoUsueiecia = GetById(clotheId);

            if (ubranieDoUsueiecia != null)
            {
                dbContext.Ubrania.Remove(ubranieDoUsueiecia);
                dbContext.SaveChanges();
            }
        }

        public void Update(object clothes)
        {
            var rzutowaneUbranie = (Ubranie)clothes;
            using (var dbContext = new MagazynDbContext())
            {
                var znalezioneUbranie = dbContext.Ubrania.Find(rzutowaneUbranie.Id);

                if (znalezioneUbranie != null)
                {
                    znalezioneUbranie.IdMarki = rzutowaneUbranie.IdMarki;
                    znalezioneUbranie.IdKategorii = rzutowaneUbranie.IdKategorii;
                    znalezioneUbranie.IdKoloru = rzutowaneUbranie.IdKoloru;
                    znalezioneUbranie.NazwaUbrania = rzutowaneUbranie.NazwaUbrania;
                    znalezioneUbranie.Cena = rzutowaneUbranie.Cena;
                    znalezioneUbranie.Ilosc = rzutowaneUbranie.Ilosc;

                    dbContext.SaveChanges();
                }
            }
        }
    }
}
