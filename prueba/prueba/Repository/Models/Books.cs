using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace prueba.Repository.Models
{
    [Table("books")]
    public partial class Books
    {
        public Books()
        {
            Inssuingquotations = new HashSet<Inssuingquotations>();
            Sheets = new HashSet<Sheets>();
            Userappbooks = new HashSet<Userappbooks>();
        }

        [Key]
        public int Id { get; set; }
        public short? IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }
        public string DataId { get; set; }
        public string Name { get; set; }
        public string DownloadUrl { get; set; }
        public string CreatedByUser { get; set; }
        public string LastModifiedBy { get; set; }

        [InverseProperty("Book")]
        public virtual ICollection<Inssuingquotations> Inssuingquotations { get; set; }
        [InverseProperty("Book")]
        public virtual ICollection<Sheets> Sheets { get; set; }
        [InverseProperty("Book")]
        public virtual ICollection<Userappbooks> Userappbooks { get; set; }
    }
}
