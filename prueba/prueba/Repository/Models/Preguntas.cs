using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace prueba.Repository.Models
{
    [Table("preguntas")]
    public partial class Preguntas
    {
        public Preguntas()
        {
            Encuestas = new HashSet<Encuestas>();
        }

        [Key]
        public int Id { get; set; }
        [Column("texto_pregunta")]
        public string TextoPregunta { get; set; }

        [InverseProperty("IdPreguntaNavigation")]
        public virtual ICollection<Encuestas> Encuestas { get; set; }
    }
}
