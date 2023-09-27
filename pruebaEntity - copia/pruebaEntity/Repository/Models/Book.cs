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
    }
}
