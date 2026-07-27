namespace AuthenticationProject.Domain.ValueObjects;

public record EmailCorporativo
{
    private const string DominioPermitido = "@ferreiracosta.com.br";
    public string? Valor { get; }
}