
using mvc_project.EMS.Domain.Entities;

namespace mvc_project.EMS.Application.Interfaces;

public interface IEmployeeRepository
{
    Task<List<Employee>> GetAllAsync();

    Task<Employee?> GetByIdAsync(int id);

    Task AddAsync(Employee emp);

    Task UpdateAsync(Employee emp);

    Task DeleteAsync(int id);
}
