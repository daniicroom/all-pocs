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
    }
}
