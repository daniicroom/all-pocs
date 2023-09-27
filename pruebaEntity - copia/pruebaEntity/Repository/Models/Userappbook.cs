using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace pruebaEntity.Repository.Models
{
    [Keyless]
    [Table("userappbooks")]
    public partial class Userappbook
    {
        public int? UserAppId { get; set; }
        public int? BookId { get; set; }
    }
}
