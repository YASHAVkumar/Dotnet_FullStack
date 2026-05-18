
using Microsoft.EntityFrameworkCore;
using mvc_project.EMS.Domain.Entities;
namespace mvc_project.EMS.Infrastructure.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {
        
    }
    public DbSet<Employee> Employees{get;set;}
     public DbSet<AppUser> Users{get;set;}
}
