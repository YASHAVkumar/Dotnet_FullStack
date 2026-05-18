using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace mvc_project.Areas.Admin;

[Authorize(Roles ="Admin")]
public class AdminController:Controller
{
}
