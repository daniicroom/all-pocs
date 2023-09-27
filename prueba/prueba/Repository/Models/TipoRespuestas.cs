using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace prueba.Repository.Models
{
    [Table("tipo_respuestas")]
    public partial class TipoRespuestas
    {
        public TipoRespuestas()
        {
            Encuestas = new HashSet<Encuestas>();
            Respuestas = new HashSet<Respuestas>();
        }

        [Key]
        public int Id { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; }

        [InverseProperty("IdTipoRespuestaNavigation")]
        public virtual ICollection<Encuestas> Encuestas { get; set; }
        [InverseProperty("TipoRespuesta")]
        public virtual ICollection<Respuestas> Respuestas { get; set; }
    }
}
