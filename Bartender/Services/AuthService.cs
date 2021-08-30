using Bartender.Models;
using Bartender.Models.ViewModels;
using Bartender.Repository;
using Bartender.Services.Interfaces;

namespace PreSemesterProject.Services
{
    public class AuthService : IAuthService
    {

        private Repository _repository;

        public AuthService(Repository repository)
        {
            _repository = repository;
        }

        public string HashPassword(string password)
        {
            throw new System.NotImplementedException();
        }

        public User ValidateLogin(LoginViewModel login)
        {
            if (login is null || string.IsNullOrEmpty(login.Username) || string.IsNullOrEmpty(login.Password)) { return default; }

            User user = _repository.Users.Find(x => x.Username.Equals(login.Username));

            if (user is null) { return default; }

            if (user.Password.Equals(login.Password))
            {
                return user;
            }
            else
            {
                return default;
            }
        }
    }
}
