using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PrivateSchoolModel
{
    public partial class PrivateSchoolEntitiesModel : DbContext
    {
        public PrivateSchoolEntitiesModel()
            : base("name=PrivateSchoolEntitiesModel")
        {
        }

        public virtual DbSet<Catalog> Catalogs { get; set; }
        public virtual DbSet<Elev> Elevs { get; set; }
        public virtual DbSet<Materie> Materies { get; set; }
        public virtual DbSet<Nota> Notas { get; set; }
        public virtual DbSet<Profesor> Profesors { get; set; }
        public virtual DbSet<Scoala> Scoalas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Elev>()
                .HasMany(e => e.Catalogs)
                .WithOptional(e => e.Elev)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Materie>()
                .HasMany(e => e.Scoalas)
                .WithOptional(e => e.Materie)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Nota>()
                .HasMany(e => e.Catalogs)
                .WithOptional(e => e.Nota)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Profesor>()
                .HasMany(e => e.Scoalas)
                .WithOptional(e => e.Profesor)
                .WillCascadeOnDelete();
        }
    }
}
