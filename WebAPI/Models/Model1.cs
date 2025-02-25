namespace WebAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DBConexion")
        {
        }

        public virtual DbSet<Movie> movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .Property(e => e.mov_name)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .Property(e => e.mov_description)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .Property(e => e.user_creation)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .Property(e => e.user_modified)
                .IsUnicode(false);
        }
    }
}
