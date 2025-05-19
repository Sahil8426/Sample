using ECommerceApp.DTOs;

namespace ECommerceApp.Services
{
    public interface IAuthService
    {
        Task<bool> Register(UserRegisterDto dto);
        Task<string> Login(UserLoginDto dto);
    }
}
