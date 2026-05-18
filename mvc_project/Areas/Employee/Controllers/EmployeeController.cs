using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace mvc_project.Areas.Employee;

[Authorize(Roles ="Employee")]
public class EmployeeController:Controller
{
}

