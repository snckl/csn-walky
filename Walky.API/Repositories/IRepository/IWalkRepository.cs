using Walky.API.Models.Domain;

namespace Walky.API.Repositories.IRepository
{
    public interface IWalkRepository
    {
        Task<Walk> CreateAsync(Walk walk);
        Task<List<Walk>> GetAllAsync(string? filterOn = null,string? filterQuery = null,string? sortBy = null);
        Task<Walk?> GetByIdAsync(Guid id);
        Task<Walk?> UpdateAsync(Guid id, Walk walk);
        Task<bool> RemoveAsync(Guid id);
    }
}
