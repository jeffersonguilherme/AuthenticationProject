using AuthenticationProject.Application.DTOs;
using AuthenticationProject.Application.Interfaces.Services;
using AuthenticationProject.Domain.Entities;
using AuthenticationProject.Domain.Excepetions;
using AuthenticationProject.Domain.ValueObjects;
using MediatR;

namespace AuthenticationProject.Application.Features.Usuarios.Commands.RegistrarUsuario;

public class RegistrarUsuarioCommandHandler : IRequestHandler<RegistrarUsuarioCommand, UsuarioLogadoDto>
{
    private readonly IRoleAssignmentService _roleAssignmentService;
    private readonly IUsuarioIdentityService _usuarioIdentityService;
    private readonly IJwtService _jwtService;

    public RegistrarUsuarioCommandHandler(IRoleAssignmentService roleAssignmentService, IUsuarioIdentityService usuarioIdentityService, IJwtService jwtService)
    {
        _roleAssignmentService = roleAssignmentService;
        _usuarioIdentityService = usuarioIdentityService;
        _jwtService = jwtService;
    }

    public async Task<UsuarioLogadoDto> Handle(RegistrarUsuarioCommand request, CancellationToken cancellationToken)
    {
        var email = new EmailCorporativo(request.Email);
        var usuario = new Usuario(request.NomeCompleto, request.Matricula, email);

        var role = await _roleAssignmentService.ObterRolePorMatriculaAync(request.Matricula);
        
        var (sucesso, erros) = await _usuarioIdentityService.CriarUsuarioAsyn(
            usuario.Id, email.Valor, request.Senha, role
        );

        if(!sucesso)
            throw new DomainException(string.Join(" | ", erros));

        var token = _jwtService.GerarToken(usuario, new List<string> { role });

        return new UsuarioLogadoDto
        {
            Token = token,
            NomeCompleto = usuario.NomeCompleto,
            Email = email.Valor,
            Roles = new List<string> { role }
        };
    }
}