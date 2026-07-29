using FluentValidation;

namespace AuthenticationProject.Application.Features.Usuarios.Commands.RegistrarUsuario;

 public class RegistrarUsuarioCommandValidator : AbstractValidator<RegistrarUsuarioCommand>
{
   public RegistrarUsuarioCommandValidator()
   {
    RuleFor(x => x.NomeCompleto).NotEmpty().MaximumLength(150);
    RuleFor(x => x.Matricula).NotEmpty().MaximumLength(20);
    RuleFor(x => x.Email).NotEmpty().EmailAddress();
    RuleFor(x => x.Senha).NotEmpty().MinimumLength(6);
   }
}