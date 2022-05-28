using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Backend_CRUD.DB_Tables
{
    [Table("Ubrania")]
    public class Ubranie
    {
        //pola tabeli 

        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        public int IdKategorii { get; set; }

        [ForeignKey("IdKategorii")]
        public virtual Kategoria Id_Kategorii { get; set; }

        public int IdKoloru { get; set; }

        [ForeignKey("IdKoloru")]
        public virtual Kolor Id_Koloru { get; set; }

        public int IdMarki { get; set; }

        [ForeignKey("IdMarki")]
        public virtual Marka Id_Marki { get; set; }

        [Required]
        [StringLength(50)]
        public string NazwaUbrania { get; set; }

        [Required]
        public decimal Cena { get; set; }

        [Required]
        public int Ilosc { get; set; }
    }
}
