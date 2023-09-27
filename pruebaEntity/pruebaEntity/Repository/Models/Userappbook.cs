using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace pruebaEntity.Repository.Models
{
    [Table("userappbooks")]
    public partial class Userappbook
    {
        [Key]
        public int UserAppId { get; set; }
        [Key]
        public int BookId { get; set; }

        [ForeignKey(nameof(BookId))]
        [InverseProperty("Userappbooks")]
        public virtual Book Book { get; set; }
        [ForeignKey(nameof(UserAppId))]
        [InverseProperty(nameof(Userapp.Userappbooks))]
        public virtual Userapp UserApp { get; set; }
    }
}
