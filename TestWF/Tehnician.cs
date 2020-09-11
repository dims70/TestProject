namespace TestWF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tehnician")]
    public partial class Tehnician
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tehnician()
        {
            Research = new HashSet<Research>();
        }

        [Key]
        public int idTehnician { get; set; }

        [Required]
        [StringLength(80)]
        public string FullName { get; set; }

        public int idRole { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Research> Research { get; set; }

        public virtual Role Role { get; set; }
    }
}
