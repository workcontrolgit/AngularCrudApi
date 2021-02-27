using AngularCRUDAPI.Application.Features.Employees.Queries.GetEmployees;
using AngularCRUDAPI.Application.Parameters;
using AngularCRUDAPI.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularCRUDAPI.Application.Interfaces.Repositories
{
    public interface IEmployeeRepositoryAsync : IGenericRepositoryAsync<Employee>
    {
        Task<(IEnumerable<Entity> data, RecordsCount recordsCount)> GetPagedEmployeeReponseAsync(GetEmployeesQuery requestParameter);
    }
}
