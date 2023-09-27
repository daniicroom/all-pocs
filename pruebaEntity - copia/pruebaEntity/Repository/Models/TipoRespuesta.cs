using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace pruebaEntity.Repository.Models
{
    [Table("tipo_respuestas")]
    public partial class TipoRespuesta
    {
        [Key]
        public int Id { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; }
    }
}
