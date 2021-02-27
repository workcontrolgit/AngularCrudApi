using AngularCRUDAPI.Application.Features.Positions.Queries.GetPositions;
using AngularCRUDAPI.Application.Parameters;
using AngularCRUDAPI.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularCRUDAPI.Application.Interfaces.Repositories
{
    public interface IPositionRepositoryAsync : IGenericRepositoryAsync<Position>
    {
        Task<bool> IsUniquePositionNumberAsync(string positionNumber);

        Task<bool> SeedDataAsync(int rowCount);

        Task<(IEnumerable<Entity> data, RecordsCount recordsCount)> GetPagedPositionReponseAsync(GetPositionsQuery requestParameters);
    }
}
