namespace TestWF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Research")]
    public partial class Research
    {
        [Key]
        public int idResearch { get; set; }

        [Required]
        [StringLength(70)]
        public string Name { get; set; }

        public int idTehnician { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateGet { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public int? idHospital { get; set; }

        public virtual Hospital Hospital { get; set; }

        public virtual Tehnician Tehnician { get; set; }
    }
}
