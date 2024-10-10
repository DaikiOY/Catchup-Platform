using CatchupPlatform.Application.Interfaces;
using CatchupPlatform.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatchupPlatform.Application.UseCases
{
    public class FavoriteSourceService
    {
        private readonly IFavoriteSourceRepository _repository;

        public FavoriteSourceService(IFavoriteSourceRepository repository)
        {
            _repository = repository;
        }

        public async Task<FavoriteSource> AddFavoriteSourceAsync(string name, string url)
        {
            var source = new FavoriteSource(name, url);
            return await _repository.AddAsync(source);
        }

        public async Task<FavoriteSource> UpdateFavoriteSourceAsync(int id, string newName, string newUrl)
        {
            var source = await _repository.GetByIdAsync(id);
            if (source != null)
            {
                source.Update(newName, newUrl);
                return await _repository.UpdateAsync(source);
            }
            return null;
        }

        public async Task DeleteFavoriteSourceAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<FavoriteSource> GetFavoriteSourceByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<FavoriteSource>> GetAllFavoriteSourcesAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}
