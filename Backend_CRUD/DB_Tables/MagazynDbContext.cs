using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Backend_CRUD.DB_Tables
{
    public class MagazynDbContext : DbContext
    {
        public MagazynDbContext() : base("MagazynDb")
        {

        }
        public DbSet<Kolor> Kolory { get; set; }
        public DbSet<Ubranie> Ubrania { get; set; }
        public DbSet<Marka> Marki { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; } 
    }
}
