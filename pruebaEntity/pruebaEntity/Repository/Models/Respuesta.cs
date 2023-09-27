using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace pruebaEntity.Repository.Models
{
    [Table("respuestas")]
    public partial class Respuesta
    {
        [Key]
        public int Id { get; set; }
        [Column("tipo_respuesta_id")]
        public int? TipoRespuestaId { get; set; }
        [Column("respuesta")]
        public string Respuesta1 { get; set; }

        [ForeignKey(nameof(TipoRespuestaId))]
        [InverseProperty("Respuesta")]
        public virtual TipoRespuesta TipoRespuesta { get; set; }
    }
}
