using Microsoft.EntityFrameworkCore;
using Walky.API.Data;
using Walky.API.Models.Domain;
using Walky.API.Repositories.IRepository;

namespace Walky.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly WalkyDbContext _dbContext;
        public RegionRepository(WalkyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Region>> GetAllAsync()
        {
           return await _dbContext.Regions.ToListAsync();
        }

        public async Task<Region?> GetByIdAsync(Guid id)
        {
           return await _dbContext.Regions.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<Region> CreateAsync(Region region)
        {
            _dbContext.Regions.Add(region);
            await _dbContext.SaveChangesAsync();
            return region;

        }

        public async Task<Region?> UpdateAsync(Guid id, Region region)
        {
            var isExistRegion = await _dbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
            if(isExistRegion == null)
            {
                return null;
            }
            isExistRegion.Code = region.Code;
            isExistRegion.Name = region.Name;
            isExistRegion.RegionImageUrl = region.RegionImageUrl;

            await _dbContext.SaveChangesAsync();
            return isExistRegion;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var region = await _dbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);

            if(region == null)
            {
                return false;
            }

            _dbContext.Remove(region);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
