using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Walky.API.Data
{
    public class WalkyAuthDbContext : IdentityDbContext
    {
        public WalkyAuthDbContext(DbContextOptions<WalkyAuthDbContext> options) : base(options)
        {
            
        }
    }
}
