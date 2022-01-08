namespace PrivateSchoolModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Scoala")]
    public partial class Scoala
    {
        public int ScoalaId { get; set; }

        public int? ProfId { get; set; }

        public int? MaterieId { get; set; }

        public virtual Materie Materie { get; set; }

        public virtual Profesor Profesor { get; set; }
    }
}
