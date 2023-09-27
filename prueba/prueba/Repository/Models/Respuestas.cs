using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace prueba.Repository.Models
{
    [Table("respuestas")]
    public partial class Respuestas
    {
        [Key]
        public int Id { get; set; }
        [Column("tipo_respuesta_id")]
        public int? TipoRespuestaId { get; set; }
        [Column("respuesta")]
        public string Respuesta { get; set; }

        [ForeignKey(nameof(TipoRespuestaId))]
        [InverseProperty(nameof(TipoRespuestas.Respuestas))]
        public virtual TipoRespuestas TipoRespuesta { get; set; }
    }
}
