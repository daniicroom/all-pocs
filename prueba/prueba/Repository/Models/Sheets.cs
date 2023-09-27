using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace prueba.Repository.Models
{
    [Table("sheets")]
    public partial class Sheets
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
        [InverseProperty(nameof(Books.Sheets))]
        public virtual Books Book { get; set; }
    }
}
