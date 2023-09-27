using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace prueba.Repository.Models
{
    [Table("userappbooks")]
    public partial class Userappbooks
    {
        [Key]
        public int UserAppId { get; set; }
        [Key]
        public int BookId { get; set; }

        [ForeignKey(nameof(BookId))]
        [InverseProperty(nameof(Books.Userappbooks))]
        public virtual Books Book { get; set; }
        [ForeignKey(nameof(UserAppId))]
        [InverseProperty(nameof(Userapp.Userappbooks))]
        public virtual Userapp UserApp { get; set; }
    }
}
