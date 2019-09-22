namespace shiyuejiuhao1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LocationDB : DbContext
    {
        public LocationDB()
            : base("name=LocationDB")
        {
        }

        public virtual DbSet<Choice> Choices { get; set; }
        public virtual DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Choice>()
                .HasOptional(e => e.Location)
                .WithRequired(e => e.Choice);
        }
    }
}
