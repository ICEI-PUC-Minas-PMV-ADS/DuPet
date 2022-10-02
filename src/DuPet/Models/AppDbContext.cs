using Microsoft.EntityFrameworkCore;

namespace DuPet.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Dose> Doses { get; set; }

    }
}
