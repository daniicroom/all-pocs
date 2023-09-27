using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace pruebaEntity.Repository.Models
{
    [Table("veredas")]
    public partial class Vereda
    {
        [Key]
        public int Id { get; set; }
        [Column("cod")]
        public string Cod { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; }
        [Column("id_muncipio_id")]
        public string IdMuncipioId { get; set; }
        [Column("logitud")]
        public string Logitud { get; set; }
        [Column("latitud")]
        public string Latitud { get; set; }
    }
}
