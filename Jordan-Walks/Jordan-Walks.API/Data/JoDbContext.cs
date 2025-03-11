using Jordan_Walks.API.Models.Domain;
using Microsoft.EntityFrameworkCore;
namespace Jordan_Walks.API.Data
{
    public class JoDbContext : DbContext
    {
        public JoDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Difficulty> difficulties{ get; set; }
        public DbSet<Rejon> rejons{ get; set; }
        public DbSet<Walks> walks{ get; set; }
    }
}
