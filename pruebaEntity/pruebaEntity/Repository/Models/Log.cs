using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace pruebaEntity.Repository.Models
{
    [Table("logs")]
    public partial class Log
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
