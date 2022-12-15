using Microsoft.EntityFrameworkCore;

namespace ProjetAPI.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext ( DbContextOptions<ApplicationDbContext> options ): base(options)
        {

        }
        public DbSet<Carte> Cartes { get; set; }
        public DbSet<Type> Types { get; set; }
    }
}