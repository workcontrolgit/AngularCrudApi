using AngularCrudApi.Application.Features.Employees.Queries.GetEmployees;
using AngularCrudApi.Application.Parameters;
using AngularCrudApi.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularCrudApi.Application.Interfaces.Repositories
{
    public interface IEmployeeRepositoryAsync : IGenericRepositoryAsync<Employee>
    {
        Task<(IEnumerable<Entity> data, RecordsCount recordsCount)> GetPagedEmployeeReponseAsync(GetEmployeesQuery requestParameter);
    }
}