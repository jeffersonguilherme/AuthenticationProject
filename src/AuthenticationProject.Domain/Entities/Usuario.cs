using AuthenticationProject.Domain.Exceptions;
using AuthenticationProject.Domain.ValueObjects;

namespace AuthenticationProject.Domain.Entities;

public class Usuario
{
    public Guid Id { get; private set; }
    public string NomeCompleto { get; private set; } = string.Empty;
    public string Matricula { get; private set; } = string.Empty;
    public EmailCorporativo? Email { get; private set; }
    public DateTime DataCriacao { get; private set; }
    public DateTime? DataAtualizacao { get; private set; }

    public static Usuario Create(string nomeCompleto, string matricula, EmailCorporativo email)
    {
        if(string.IsNullOrWhiteSpace(nomeCompleto))
            throw new DomainException("O nome completo é obrigatório.");

        if(string.IsNullOrWhiteSpace(matricula))
            throw new DomainException("A matrícula é obirgatória.");

        var usuario = new Usuario
        {
            Id = Guid.NewGuid(),
            NomeCompleto = nomeCompleto,
            Matricula = matricula,
            Email = email,
            DataCriacao = DateTime.UtcNow
        };
        return usuario;
    }

    public void AtualizarDados(string nomeCompleto, string matricula, EmailCorporativo email)
    {
       if(string.IsNullOrWhiteSpace(nomeCompleto))
            throw new DomainException("O nome completo é obrigatório.");

        if(string.IsNullOrWhiteSpace(matricula))
            throw new DomainException("A matrícula é obirgatória.");

        NomeCompleto = nomeCompleto;
        Matricula = matricula;
        Email = email;
        DataAtualizacao = DateTime.UtcNow; 
    }
}