using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace PocAauth.Data
{
    public class UserApp : IdentityUser<int>
    {
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow.ToLocalTime();

        /// <summary>
        /// Fecha de actualización del registro por última vez.
        /// </summary>
        public DateTime? UpdatedAt { get; set; } = null;

        /// <summary>
        /// Indica si el registro posee borrado lógico.
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
