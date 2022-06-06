using Backend_CRUD.DB_Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend_CRUD.Repozytorium
{
    public class MarkaRepozytrium : IMarkaRepozytorium
    {
        private MagazynDbContext dbContext;

        public MarkaRepozytrium()
        {
            dbContext = new MagazynDbContext();
        }

        public Marka GetById(int id)
        {
            Marka wynik = null;

            wynik = dbContext.Marki.Find(id);

            return wynik;
        }

        public IEnumerable<Marka> GetAll()
        {
            List<Marka> wyniki = new List<Marka>();
            using (var dbContext = new MagazynDbContext())
            {
                wyniki = dbContext.Marki.OrderBy(x => x.Id).ToList();
            }
            return wyniki;
        }

        public void Add(object brand)
        {
            var rzutowanaMarka = (Marka)brand;
            using (var dbContext = new MagazynDbContext())
            {

                var brandToPass = new Marka()
                {
                    NazwaMarki = rzutowanaMarka.NazwaMarki
                };

                dbContext.Marki.Add(brandToPass);
                dbContext.SaveChanges();
            }
        }

        public void Remove(int brandId)
        {
            var brandToDelete = GetById(brandId);

            if (brandToDelete != null)
            {
                dbContext.Marki.Remove(brandToDelete);
                dbContext.SaveChanges();
            }
        }

        public void Update(object brand)
        {
            var rzutowanaMarka = (Marka)brand;
            using (var dbContext = new MagazynDbContext())
            {
                var znalezionaMarka = dbContext.Marki.Find(rzutowanaMarka.Id);

                if (znalezionaMarka != null)
                {
                    znalezionaMarka.NazwaMarki = rzutowanaMarka.NazwaMarki;

                    dbContext.SaveChanges();
                }
            }
        }
    }
}
