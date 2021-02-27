using AngularCrudApi.Application.Features.Positions.Queries.GetPositions;
using AngularCrudApi.Application.Parameters;
using AngularCrudApi.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularCrudApi.Application.Interfaces.Repositories
{
    public interface IPositionRepositoryAsync : IGenericRepositoryAsync<Position>
    {
        Task<bool> IsUniquePositionNumberAsync(string positionNumber);

        Task<bool> SeedDataAsync(int rowCount);

        Task<(IEnumerable<Entity> data, RecordsCount recordsCount)> GetPagedPositionReponseAsync(GetPositionsQuery requestParameters);
    }
}
