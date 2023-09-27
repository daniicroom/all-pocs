using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace prueba.Repository.Models
{
    [Table("subtipos_cultivos")]
    public partial class SubtiposCultivos
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
        [InverseProperty(nameof(TiposCultivos.SubtiposCultivos))]
        public virtual TiposCultivos IdTipoCultivoNavigation { get; set; }
    }
}
