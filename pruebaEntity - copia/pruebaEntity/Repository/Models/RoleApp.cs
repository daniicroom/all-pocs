using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace pruebaEntity.Repository.Models
{
    [Keyless]
    [Table("roleApp")]
    public partial class RoleApp
    {
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
    }
}
