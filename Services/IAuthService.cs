using AuthDemo.Api.Model;

namespace AuthDemo.Api.Services
{
    public interface IAuthService
    {
   
        Task<bool> Login(LoginUser user);
        Task<bool> RegisterUser(LoginUser user);
    }
}