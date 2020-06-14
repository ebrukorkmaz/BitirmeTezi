namespace proje1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProjeDB : DbContext
    {
        public ProjeDB()
            : base("name=ProjeDB")
        {
        }

        public virtual DbSet<Kullanici> Kullanicis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
