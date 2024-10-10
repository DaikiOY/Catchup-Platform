using CatchUpPlatform.API.Source.Domain.Model.Aggregates;
using CatchUpPlatform.API.Source.Domain.Model.Queries;

namespace CatchUpPlatform.API.Source.Domain.Services
{
    public interface IFavoriteSourceQueryService
    {
        Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query);
        Task<FavoriteSource?> Handle(GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query);
    }
}
