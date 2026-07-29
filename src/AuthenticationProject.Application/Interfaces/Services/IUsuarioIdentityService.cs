namespace AuthenticationProject.Application.Interfaces.Services;

public interface IUsuarioIdentityService
{
    Task<(bool Sucesso, IEnumerable<string> Erros)> CriarUsuarioAsyn(Guid usuarioId, string email, string senha, string role);
    Task<(bool Sucesso, string? usuarioId, IList<string> Roles)> ValidarCredenciasAsync(string email, string senha);
}