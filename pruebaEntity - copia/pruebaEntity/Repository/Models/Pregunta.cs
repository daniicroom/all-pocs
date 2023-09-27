﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace pruebaEntity.Repository.Models
{
    [Table("preguntas")]
    public partial class Pregunta
    {
        [Key]
        public int Id { get; set; }
        [Column("texto_pregunta")]
        public string TextoPregunta { get; set; }
    }
}
