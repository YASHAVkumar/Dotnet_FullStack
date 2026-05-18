using mvc_project.EMS.Domain.Entities;

namespace mvc_project.EMS.Application.Interfaces;

public interface IAuthService
{
    Task<AppUser?> LoginAsync(string email,
                              string password);

    string GenerateJwtToken(AppUser user);
}
