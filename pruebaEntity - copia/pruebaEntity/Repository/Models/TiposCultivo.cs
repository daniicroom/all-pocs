using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace pruebaEntity.Repository.Models
{
    [Table("tiposCultivos")]
    public partial class TiposCultivo
    {
        [Key]
        public int Id { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; }
        [Column("habilitado")]
        public byte? Habilitado { get; set; }
    }
}
