using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace pruebaEntity.Repository.Models
{
    [Table("sheets")]
    public partial class Sheet
    {
        [Key]
        public int Id { get; set; }
        public short? IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }
        public string DataId { get; set; }
        public string Name { get; set; }
        public int? PositionBook { get; set; }
        public int? PositionValue { get; set; }
        public string Visibility { get; set; }
        public int? BookId { get; set; }
        public string Range { get; set; }

        [ForeignKey(nameof(BookId))]
        [InverseProperty("Sheets")]
        public virtual Book Book { get; set; }
    }
}
