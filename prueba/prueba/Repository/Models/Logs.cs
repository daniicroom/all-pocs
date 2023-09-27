using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace prueba.Repository.Models
{
    [Table("logs")]
    public partial class Logs
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(100)]
        public string Timestamp { get; set; }
        [StringLength(15)]
        public string Level { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public string Properties { get; set; }
        [Column("_ts", TypeName = "datetime")]
        public DateTime? Ts { get; set; }
    }
}
