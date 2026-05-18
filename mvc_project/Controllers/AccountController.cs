using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using mvc_project.EMS.Domain.Entities;
using mvc_project.EMS.Infrastructure.Data;
using mvc_project.Models;
using System.Security.Claims;
namespace mvc_project.EMS.Web.Controllers;

public class AccountController:Controller
{
     private readonly AppDbContext _context;

    public AccountController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(
        string email,
        string password)
    {
        var user = _context.Users
            .FirstOrDefault(x =>
                x.Email == email &&
                x.PasswordHash == password);

        if(user == null)
        {
            ViewBag.Error = "Invalid Credentials";

            return View();
        }

        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.Name),
            new Claim(ClaimTypes.Role, user.Role)
        };

        var identity = new ClaimsIdentity(
            claims,
            CookieAuthenticationDefaults
                .AuthenticationScheme);

        await HttpContext.SignInAsync(
            CookieAuthenticationDefaults
                .AuthenticationScheme,
            new ClaimsPrincipal(identity));

        if(user.Role == "Admin")
            return RedirectToAction("Index",
                                    "Employee");

        return RedirectToAction("Dashboard",
                                "EmployeePanel");
    }

    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync();

        return RedirectToAction("Login");
    }
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(
    RegisterViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        bool exists = _context.Users
            .Any(x => x.Email == model.Email);

        if (exists)
        {
            ViewBag.Error = "Email already exists";

            return View(model);
        }

        AppUser user = new()
        {
            Name = model.Name,
            Email = model.Email,
            Role = model.Role,

            // temporary
            PasswordHash = model.Password
        };

        _context.Users.Add(user);

        await _context.SaveChangesAsync();

        return RedirectToAction("Login");
    }
}
