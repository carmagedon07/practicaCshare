using Microsoft.EntityFrameworkCore;
using MiCrudApi.Models;

namespace MiCrudApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>()
                .HasMany(p => p.Mascotas)
                .WithOne(p => p.Persona)
                .HasForeignKey(p => p.PersonaId);

                base.OnModelCreating(modelBuilder);
        }

    }
    
}