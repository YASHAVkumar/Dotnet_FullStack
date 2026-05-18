using Microsoft.AspNetCore.Mvc;
using mvc_project.EMS.Application.Services;
using mvc_project.EMS.Domain.Entities;
using X.PagedList.Extensions;

namespace mvc_project.Controllers;

public class EmployeeController:Controller
{
    public readonly EmployeeService _service;
    public EmployeeController(EmployeeService service)
    {
        _service=service;
    }
    public async Task<IActionResult> Index(
        string search,
        int page = 1)
    {
        var employees = await _service.GetAllAsync();

        if(!string.IsNullOrEmpty(search))
        {
            employees = employees
                .Where(x =>
                    x.Name.Contains(search,
                        StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        int pageSize = 5;

        return View(
            employees.ToPagedList(page,
                                  pageSize));
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(
        Employee employee,
        IFormFile file)
    {
        if(file != null)
        {
            string folder = Path.Combine(
                Directory.GetCurrentDirectory(),
                "wwwroot/uploads");

            if(!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            string filePath = Path.Combine(
                folder,
                file.FileName);

            using FileStream stream =
                new(filePath, FileMode.Create);

            await file.CopyToAsync(stream);

            employee.ImagePath = file.FileName;
        }

        await _service.AddAsync(employee);

        return RedirectToAction(nameof(Index));
    }
}
