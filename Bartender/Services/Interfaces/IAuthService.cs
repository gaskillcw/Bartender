using Bartender.Models;
using Bartender.Models.ViewModels;

namespace Bartender.Services.Interfaces
{
    public interface IAuthService
    {
        string HashPassword(string password);
        User ValidateLogin(LoginViewModel login);
    }
}
