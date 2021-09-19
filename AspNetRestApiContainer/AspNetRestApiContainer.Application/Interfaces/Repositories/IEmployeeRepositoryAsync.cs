using AspNetRestApiContainer.Application.Features.Employees.Queries.GetEmployees;
using AspNetRestApiContainer.Application.Parameters;
using AspNetRestApiContainer.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetRestApiContainer.Application.Interfaces.Repositories
{
    public interface IEmployeeRepositoryAsync : IGenericRepositoryAsync<Employee>
    {
        Task<(IEnumerable<Entity> data, RecordsCount recordsCount)> GetPagedEmployeeReponseAsync(GetEmployeesQuery requestParameter);
    }
}