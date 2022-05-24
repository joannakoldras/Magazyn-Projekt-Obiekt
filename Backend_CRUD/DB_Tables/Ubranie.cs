using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_CRUD.DB_Tables
{
    public class Ubranie
    {
        //pola tabeli 
        public int Id { get; set; }
        public string NazwaUbrania { get; set; }
        public decimal Cena { get; set; }
        public int Ilosc { get; set; }
        public int IdMarki {get; set; }
        public int IdKategorii { get; set; }
        public int IdKoloru { get; set; } 
    }
}
