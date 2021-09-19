using AspNetRestApiContainer.Application.Features.Positions.Queries.GetPositions;
using AspNetRestApiContainer.Application.Parameters;
using AspNetRestApiContainer.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetRestApiContainer.Application.Interfaces.Repositories
{
    public interface IPositionRepositoryAsync : IGenericRepositoryAsync<Position>
    {
        Task<bool> IsUniquePositionNumberAsync(string positionNumber);

        Task<bool> SeedDataAsync(int rowCount);

        Task<(IEnumerable<Entity> data, RecordsCount recordsCount)> GetPagedPositionReponseAsync(GetPositionsQuery requestParameters);
    }
}