using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace prueba.Repository.Models
{
    [Table("input")]
    public partial class Input
    {
        public Input()
        {
            Inssuingquotations = new HashSet<Inssuingquotations>();
            Quote = new HashSet<Quote>();
        }

        [Key]
        public int Id { get; set; }
        public short? IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }
        public string SidewalkId { get; set; }
        public int? ProductiveSystemId { get; set; }
        public string CropYield { get; set; }
        public string CropProductionCosts { get; set; }
        public string InitialSowingDate { get; set; }
        public string FinalSowingDate { get; set; }
        public string AreaCrop { get; set; }
        public short? FinagroCcredit { get; set; }
        public string PlantsByHectare { get; set; }
        public string ClientSize { get; set; }

        [InverseProperty("Input")]
        public virtual ICollection<Inssuingquotations> Inssuingquotations { get; set; }
        [InverseProperty("Input")]
        public virtual ICollection<Quote> Quote { get; set; }
    }
}
