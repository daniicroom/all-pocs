using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace pruebaEntity.Repository.Models
{
    [Table("books")]
    public partial class Book
    {
        public Book()
        {
            Inssuingquotations = new HashSet<Inssuingquotation>();
            Sheets = new HashSet<Sheet>();
            Userappbooks = new HashSet<Userappbook>();
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

        [InverseProperty(nameof(Inssuingquotation.Book))]
        public virtual ICollection<Inssuingquotation> Inssuingquotations { get; set; }
        [InverseProperty(nameof(Sheet.Book))]
        public virtual ICollection<Sheet> Sheets { get; set; }
        [InverseProperty(nameof(Userappbook.Book))]
        public virtual ICollection<Userappbook> Userappbooks { get; set; }
    }
}
