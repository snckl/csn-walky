using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Walky.API.Data
{
    public class WalkyAuthDbContext : IdentityDbContext
    {
        public WalkyAuthDbContext(DbContextOptions<WalkyAuthDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "c47a9ff9-e60f-439d-915b-6539abd14cbc";
            var writerRoleId = "2288c580-ab12-4317-9ebb-d486bab44154";

            var roles = new List<IdentityRole>()
            {
                new IdentityRole
                {
                    Id = readerRoleId,
                    ConcurrencyStamp = readerRoleId,
                    Name = "Reader",
                    NormalizedName = "Reader".ToUpper()
                },
                new IdentityRole
                {
                    Id = writerRoleId,
                    ConcurrencyStamp = writerRoleId,
                    Name = "Writer",
                    NormalizedName = "Writer".ToUpper()
                }
            };


            builder.Entity<IdentityRole>().HasData(roles);

        }
    }
}
