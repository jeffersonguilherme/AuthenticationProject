namespace AuthenticationProject.Application.DTOs;

public class UsuarioLogadoDto
{
    public string Token { get; set; } = string.Empty;
    public string NomeCompleto { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public IList<string> Roles { get; set; } = new List<string>();
}