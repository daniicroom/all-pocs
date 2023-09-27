using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PocAauth.Data
{
    public class IEntity
    {
        /// <summary>
        /// Llave primaria, identificador único.
        /// </summary>
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Indica si el registro posee borrado lógico.
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// Fecha de creación del registro.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow.ToLocalTime();

        /// <summary>
        /// Fecha de actualización del registro por última vez.
        /// </summary>
        public DateTime? UpdatedAt { get; set; } = null;
    }
}
