using CatchupPlatform.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatchupPlatform.Application.Interfaces
{
    public interface IFavoriteSourceRepository
    {
        Task<FavoriteSource> AddAsync(FavoriteSource source);
        Task<FavoriteSource> UpdateAsync(FavoriteSource source);
        Task DeleteAsync(int id);
        Task<FavoriteSource> GetByIdAsync(int id);
        Task<IEnumerable<FavoriteSource>> GetAllAsync();
    }
}
