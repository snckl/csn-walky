using Microsoft.EntityFrameworkCore;
using Walky.API.Models.Domain;

namespace Walky.API.Data
{
    public class WalkyDbContext : DbContext
    {
        public WalkyDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

    }
}
