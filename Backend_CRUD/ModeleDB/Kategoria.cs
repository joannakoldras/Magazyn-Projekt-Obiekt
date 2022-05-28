using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Backend_CRUD.DB_Tables
{
    [Table("Kategorie")]
    public class Kategoria
    {
        [Column("IdKategorii")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string NazwaKategorii { get; set; }
    }
}
