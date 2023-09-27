using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace pruebaEntity.Repository.Models
{
    [Table("quote")]
    public partial class Quote
    {
        [Key]
        public int Id { get; set; }
        public short? IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int? InputId { get; set; }

        [ForeignKey(nameof(InputId))]
        [InverseProperty("Quotes")]
        public virtual Input Input { get; set; }
    }
}
