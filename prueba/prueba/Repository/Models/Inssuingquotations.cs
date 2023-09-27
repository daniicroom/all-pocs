using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace prueba.Repository.Models
{
    [Table("inssuingquotations")]
    public partial class Inssuingquotations
    {
        [Key]
        public int Id { get; set; }
        public short? IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }
        public int? UserAppId { get; set; }
        public int? InputId { get; set; }
        public int? BookId { get; set; }
        public string SesionId { get; set; }
        public string Guid { get; set; }

        [ForeignKey(nameof(BookId))]
        [InverseProperty(nameof(Books.Inssuingquotations))]
        public virtual Books Book { get; set; }
        [ForeignKey(nameof(InputId))]
        [InverseProperty("Inssuingquotations")]
        public virtual Input Input { get; set; }
        [ForeignKey(nameof(UserAppId))]
        [InverseProperty(nameof(Userapp.Inssuingquotations))]
        public virtual Userapp UserApp { get; set; }
    }
}
