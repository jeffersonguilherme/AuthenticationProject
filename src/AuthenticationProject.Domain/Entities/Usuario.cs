
using AuthenticationProject.Domain.Excepetions;
using AuthenticationProject.Domain.ValueObjects;

namespace AuthenticationProject.Domain.Entities;

public class Usuario
{
    public Guid Id { get; private set; }
    public string NomeCompleto { get; private set; }
    public string Matricula { get; private set; }
    public EmailCorporativo Email { get; private set; }
    public DateTime DataCriacao { get; private set; }
    public DateTime? DataAtualizacao { get; private set; }

    protected Usuario() { } // EF/serialização, se precisar

    public Usuario(string nomeCompleto, string matricula, EmailCorporativo email)
    {
        if (string.IsNullOrWhiteSpace(nomeCompleto))
            throw new DomainException("O nome completo é obrigatório.");

        if (string.IsNullOrWhiteSpace(matricula))
            throw new DomainException("A matrícula é obrigatória.");

        Id = Guid.NewGuid();
        NomeCompleto = nomeCompleto;
        Matricula = matricula;
        Email = email;
        DataCriacao = DateTime.UtcNow;
    }

    public void AtualizarDados(string nomeCompleto)
    {
        if (string.IsNullOrWhiteSpace(nomeCompleto))
            throw new DomainException("O nome completo é obrigatório.");

        NomeCompleto = nomeCompleto;
        DataAtualizacao = DateTime.UtcNow;
    }
}