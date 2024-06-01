using Walky.API.Models.Domain;

namespace Walky.API.Repositories.IRepository
{
    public interface IWalkRepository
    {
        Task<Walk> CreateAsync(Walk walk);
        Task<List<Walk>> GetAllAsync();
        Task<Walk?> GetByIdAsync(Guid id);
    }
}
