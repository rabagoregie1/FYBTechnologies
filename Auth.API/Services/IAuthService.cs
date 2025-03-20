using Auth.API.Models;

namespace Auth.API.Services
{
    public interface IAuthService
    {
        Task<User> Register(RegisterRequest request);
        Task<AuthResponse> Login(LoginRequest request);
        Task<User> GetUserById(int userId);
    }
}
