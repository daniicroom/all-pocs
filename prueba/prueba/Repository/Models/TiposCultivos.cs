using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace prueba.Repository.Models
{
    [Table("tiposCultivos")]
    public partial class TiposCultivos
    {
        public TiposCultivos()
        {
            SubtiposCultivos = new HashSet<SubtiposCultivos>();
        }

        [Key]
        public int Id { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; }
        [Column("habilitado")]
        public byte? Habilitado { get; set; }

        [InverseProperty("IdTipoCultivoNavigation")]
        public virtual ICollection<SubtiposCultivos> SubtiposCultivos { get; set; }
    }
}
