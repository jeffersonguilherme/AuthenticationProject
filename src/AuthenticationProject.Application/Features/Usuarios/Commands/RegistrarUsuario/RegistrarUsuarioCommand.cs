using AuthenticationProject.Application.DTOs;
using MediatR;

namespace AuthenticationProject.Application.Features.Usuarios.Commands.RegistrarUsuario;

public class RegistrarUsuarioCommand : IRequest<UsuarioLogadoDto>
{
    public string NomeCompleto { get; set; } = string.Empty;
    public string Matricula { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
}