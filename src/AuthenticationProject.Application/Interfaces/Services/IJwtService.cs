using AuthenticationProject.Domain.Entities;

namespace AuthenticationProject.Application.Interfaces.Services;

public interface IJwtService
{
    string GerarToken(Usuario usuario, List<string> roles);
}