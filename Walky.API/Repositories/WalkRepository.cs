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

        public async Task<List<Walk>> GetAllAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, int pageNumber = 1, int pageSize = 25 )
        {
            var walks = _dbContext.Walks.Include(x => x.Difficulty).Include(x => x.Region).AsQueryable();

            if (!string.IsNullOrWhiteSpace(filterOn) && !string.IsNullOrWhiteSpace(filterQuery))
            {
                if (filterOn.Equals("Name", StringComparison.OrdinalIgnoreCase)){
                    walks = walks.Where(x => x.Name.Contains(filterQuery));
                }  
            }
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                if(sortBy.Equals("Name", StringComparison.OrdinalIgnoreCase))
                {
                    walks = walks.OrderBy(x => x.Name);
                }
            }

            return await walks.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task<Walk?> GetByIdAsync(Guid id)
        {
           return await _dbContext.Walks.Include(x => x.Difficulty).Include(x => x.Region).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Walk?> UpdateAsync(Guid id, Walk walk)
        {
            var walkDb = await _dbContext.Walks.Include(x => x.Difficulty).Include(x => x.Region).FirstOrDefaultAsync(x => x.Id == id);
            if(walkDb == null)
            {
                return null;
            }

            walkDb.Name = walk.Name ?? walkDb.Name;
            walkDb.Description = walk.Description ?? walkDb.Description;
            walkDb.LengthInKm = walk.LengthInKm != 0 ? walk.LengthInKm : walkDb.LengthInKm;
            walkDb.WalkImageUrl = walk.WalkImageUrl ?? walkDb.WalkImageUrl;
            walkDb.DifficultyId = walk.DifficultyId != Guid.Empty ? walk.DifficultyId : walkDb.DifficultyId;
            walkDb.RegionId = walk.RegionId != Guid.Empty ? walk.RegionId : walkDb.RegionId;

            await _dbContext.SaveChangesAsync();

            return walkDb;
        }


        public async Task<bool> RemoveAsync(Guid id)
        {
            var walkDb = await _dbContext.Walks.FirstOrDefaultAsync(x => x.Id == id);

            if(walkDb == null)
            {
                return false;
            }

            _dbContext.Remove(walkDb);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
