using System.Text.RegularExpressions;
using AuthenticationProject.Domain.Excepetions;

namespace AuthenticationProject.Domain.ValueObjects;

public record EmailCorporativo
{
    private const string DominioPermitido = "@ferreiracosta.com.br";

    public string Valor { get; }

    public EmailCorporativo(string valor)
    {
        if (string.IsNullOrWhiteSpace(valor))
            throw new DomainException("O e-mail não pode ser vazio.");

        if (!Regex.IsMatch(valor, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            throw new DomainException("Formato de e-mail inválido.");

        if (!valor.EndsWith(DominioPermitido, StringComparison.OrdinalIgnoreCase))
            throw new DomainException($"O e-mail precisa pertencer ao domínio {DominioPermitido}.");

        Valor = valor.ToLowerInvariant();
    }

    public override string ToString() => Valor;
}