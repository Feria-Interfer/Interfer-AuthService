
using AuthService_Interfer.Domain.Entities;

namespace AuthService_Interfer.Application.Interfaces;

public interface IJwtTokenService
{
    string GenerateToken(User user);
}