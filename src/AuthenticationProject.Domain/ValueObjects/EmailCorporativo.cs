namespace AuthenticationProject.Domain.ValueObjects;

public record EmailCorporativo
{
    private const string DominioPermitido = "@ferreiracosta.com.br";
    public string? Valor { get; }

    public EmailCorporativo(string valor)
    {
        if(string.IsNullOrWhiteSpace(valor))
            throw new DomainException()
    }
}