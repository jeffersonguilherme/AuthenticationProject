using AuthenticationProject.Application.DTOs;
using MediatR;

namespace AuthenticationProject.Application.Features.Usuarios.Commands.Login;

public class LoginCommand : IRequest<UsuarioLogadoDto>
{
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
}