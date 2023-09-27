using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace prueba.Repository.Models
{
    public partial class Departamentos
    {
        [Key]
        public int Id { get; set; }
        [Column("cod")]
        public string Cod { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; }
    }
}
