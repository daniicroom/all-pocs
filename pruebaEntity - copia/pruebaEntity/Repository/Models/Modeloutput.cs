using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace pruebaEntity.Repository.Models
{
    [Table("modeloutputs")]
    public partial class Modeloutput
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Valor { get; set; }
        public string Descriptor { get; set; }
        public string MensajeError { get; set; }
        public string MostrarEnPantalla { get; set; }
        public int? PosicionValor { get; set; }
    }
}
