using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Backend_CRUD.DB_Tables
{
    [Table("Kolory")]
    public class Kolor
    {
        [Column("IdKoloru")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string NazwaKoloru { get; set; }
    }
}
