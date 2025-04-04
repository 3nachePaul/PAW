using Lab4.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab4.ContextModels
{
    public class StiriContext : DbContext
    {
        public DbSet<Stire> Stiri { get; set; }
        public DbSet<Categorie> Categorii { get; set; }

        public StiriContext(DbContextOptions<StiriContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stire>()
                .HasOne(s => s.Categorie)
                .WithMany(c => c.Stiri)
                .HasForeignKey(s => s.CategorieId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
