using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace prueba.Repository.Models
{
    [Table("encuestas")]
    public partial class Encuestas
    {
        [Key]
        public int Id { get; set; }
        [Column("id_pregunta")]
        public int? IdPregunta { get; set; }
        [Column("id_sistema_productivo")]
        public int? IdSistemaProductivo { get; set; }
        [Column("id_tipo_respuesta")]
        public int? IdTipoRespuesta { get; set; }
        [Column("respuesta_manual")]
        public string RespuestaManual { get; set; }

        [ForeignKey(nameof(IdPregunta))]
        [InverseProperty(nameof(Preguntas.Encuestas))]
        public virtual Preguntas IdPreguntaNavigation { get; set; }
        [ForeignKey(nameof(IdTipoRespuesta))]
        [InverseProperty(nameof(TipoRespuestas.Encuestas))]
        public virtual TipoRespuestas IdTipoRespuestaNavigation { get; set; }
    }
}
