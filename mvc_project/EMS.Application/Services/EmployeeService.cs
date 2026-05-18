using mvc_project.EMS.Application.Interfaces;
using mvc_project.EMS.Domain.Entities;

namespace mvc_project.EMS.Application.Services;

public class EmployeeService
{
    private readonly IEmployeeRepository _repo;

    public EmployeeService(IEmployeeRepository repo)
    {
        _repo = repo;
    }

    public async Task<List<Employee>> GetAllAsync()
    {
        return await _repo.GetAllAsync();
    }

    public async Task AddAsync(Employee employee)
    {
        employee.CreatedAt = DateTime.Now;

        await _repo.AddAsync(employee);
    }
}
