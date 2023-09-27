using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace prueba.Repository.Models
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
        [InverseProperty("Quote")]
        public virtual Input Input { get; set; }
    }
}
