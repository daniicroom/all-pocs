using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace pruebaEntity.Repository.Models
{
    [Table("userapp")]
    public partial class Userapp
    {
        public Userapp()
        {
            Inssuingquotations = new HashSet<Inssuingquotation>();
            RoleApps = new HashSet<RoleApp>();
            Userappbooks = new HashSet<Userappbook>();
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

        [InverseProperty(nameof(Inssuingquotation.UserApp))]
        public virtual ICollection<Inssuingquotation> Inssuingquotations { get; set; }
        [InverseProperty(nameof(RoleApp.User))]
        public virtual ICollection<RoleApp> RoleApps { get; set; }
        [InverseProperty(nameof(Userappbook.UserApp))]
        public virtual ICollection<Userappbook> Userappbooks { get; set; }
    }
}
