using CatchupPlatform.Application.Interfaces;
using CatchupPlatform.Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatchupPlatform.Infrastructure.Repositories
{
    public class FavoriteSourceRepository : IFavoriteSourceRepository
    {
        private readonly List<FavoriteSource> _sources = new List<FavoriteSource>();

        public async Task<FavoriteSource> AddAsync(FavoriteSource source)
        {
            source.Id = _sources.Count > 0 ? _sources.Max(s => s.Id) + 1 : 1;
            _sources.Add(source);
            return await Task.FromResult(source);
        }

        public async Task<FavoriteSource> UpdateAsync(FavoriteSource source)
        {
            var existingSource = _sources.FirstOrDefault(s => s.Id == source.Id);
            if (existingSource != null)
            {
                existingSource.Update(source.Name, source.Url);
            }
            return await Task.FromResult(existingSource);
        }

        public async Task DeleteAsync(int id)
        {
            var source = _sources.FirstOrDefault(s => s.Id == id);
            if (source != null)
            {
                _sources.Remove(source);
            }
            await Task.CompletedTask;
        }

        public async Task<FavoriteSource> GetByIdAsync(int id)
        {
            var source = _sources.FirstOrDefault(s => s.Id == id);
            return await Task.FromResult(source);
        }

        public async Task<IEnumerable<FavoriteSource>> GetAllAsync()
        {
            return await Task.FromResult(_sources.AsEnumerable());
        }
    }
}
