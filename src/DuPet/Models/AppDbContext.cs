using Microsoft.EntityFrameworkCore;

namespace DuPet.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder) {

            builder.Entity<PetUsuarios>()
                .HasKey(c => new { c.PetId, c.UsuarioId });

            builder.Entity<PetUsuarios>()
                .HasOne(c => c.Pet).WithMany(c => c.Usuarios)
                .HasForeignKey(c => c.PetId);

            builder.Entity<PetUsuarios>()
                .HasOne(c => c.Usuario).WithMany(c => c.Pets)
                .HasForeignKey(c => c.UsuarioId);
        }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Dose> Doses { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<PetUsuarios> PetsUsuarios { get; set; }

    }
}
