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
        public TipoRespuesta()
        {
            Encuesta = new HashSet<Encuesta>();
            Respuesta = new HashSet<Respuesta>();
        }

        [Key]
        public int Id { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; }

        [InverseProperty("IdTipoRespuestaNavigation")]
        public virtual ICollection<Encuesta> Encuesta { get; set; }
        [InverseProperty("TipoRespuesta")]
        public virtual ICollection<Respuesta> Respuesta { get; set; }
    }
}
