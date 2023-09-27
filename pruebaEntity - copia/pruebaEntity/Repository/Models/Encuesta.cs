using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace pruebaEntity.Repository.Models
{
    [Table("encuestas")]
    public partial class Encuesta
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
    }
}
