namespace TestWF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hospital")]
    public partial class Hospital
    {
        [Key]
        public int idHospital { get; set; }

        [Required]
        [StringLength(50)]
        public string NameHospital { get; set; }

        public int Adress { get; set; }
    }
}
