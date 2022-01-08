namespace PrivateSchoolModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Profesor")]
    public partial class Profesor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profesor()
        {
            Scoalas = new HashSet<Scoala>();
        }

        [Key]
        public int ProfId { get; set; }

        [StringLength(50)]
        public string numeprof { get; set; }

        [StringLength(50)]
        public string prenumeprof { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_angajare { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Scoala> Scoalas { get; set; }
    }
}
