using Microsoft.EntityFrameworkCore;
using Walky.API.Data;
using Walky.API.Models.Domain;
using Walky.API.Repositories.IRepository;

namespace Walky.API.Repositories
{
    public class WalkRepository : IWalkRepository
    {

        private readonly WalkyDbContext _dbContext;

        public WalkRepository(WalkyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Walk>  CreateAsync(Walk walk)
        {
           await _dbContext.Walks.AddAsync(walk);
           await _dbContext.SaveChangesAsync();
           return walk;
        }

        public async Task<List<Walk>> GetAllAsync()
        {
            return await _dbContext.Walks.Include(x => x.Difficulty).Include(x => x.Region).ToListAsync();
        }

        public async Task<Walk> GetByIdAsync(Guid id)
        {
           return await _dbContext.Walks.Include(x => x.Difficulty).Include(x => x.Region).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
