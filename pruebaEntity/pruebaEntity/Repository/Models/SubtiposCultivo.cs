using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace pruebaEntity.Repository.Models
{
    [Table("subtipos_cultivos")]
    public partial class SubtiposCultivo
    {
        [Key]
        public int Id { get; set; }
        [Column("cod")]
        public string Cod { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; }
        [Column("id_tipo_cultivo")]
        public int? IdTipoCultivo { get; set; }
        [Column("tipo")]
        public string Tipo { get; set; }
        [Column("habilitado")]
        public int? Habilitado { get; set; }

        [ForeignKey(nameof(IdTipoCultivo))]
        [InverseProperty(nameof(TiposCultivo.SubtiposCultivos))]
        public virtual TiposCultivo IdTipoCultivoNavigation { get; set; }
    }
}
