using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace pruebaEntity.Repository.Models
{
    [Table("roleApp")]
    public partial class RoleApp
    {
        [Key]
        public int UserId { get; set; }
        [Key]
        public int RoleId { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Userapp.RoleApps))]
        public virtual Userapp User { get; set; }
    }
}
