using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace prueba.Repository.Models
{
    [Table("userapp")]
    public partial class Userapp
    {
        public Userapp()
        {
            Inssuingquotations = new HashSet<Inssuingquotations>();
            RoleApp = new HashSet<RoleApp>();
            Userappbooks = new HashSet<Userappbooks>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(256)]
        public string UserName { get; set; }
        [StringLength(85)]
        public string NormalizedUserName { get; set; }
        [StringLength(256)]
        public string Email { get; set; }
        [StringLength(85)]
        public string NormalizedEmail { get; set; }
        public short? EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public short? PhoneNumberConfirmed { get; set; }
        public short? TwoFactorEnabled { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LockoutEnd { get; set; }
        public short? LockoutEnabled { get; set; }
        public int? AccessFailedCount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public short? IsEnabled { get; set; }

        [InverseProperty("UserApp")]
        public virtual ICollection<Inssuingquotations> Inssuingquotations { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<RoleApp> RoleApp { get; set; }
        [InverseProperty("UserApp")]
        public virtual ICollection<Userappbooks> Userappbooks { get; set; }
    }
}
