
using AuthenticationProject.Domain.Excepetions;

namespace AuthenticationProject.Domain.Entities;

public class Produto
{
    public Guid Id { get; private set; }
    public string Nome { get; private set; } = string.Empty;
    public DateTime DataCriacao { get; private set; }
    public DateTime? DataAtualizacao { get; private set; }

    protected Produto() { }

    public static Produto Create(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new DomainException("O nome do produto é obrigatório.");

        return new Produto()
        {
        Id = Guid.NewGuid(),
        Nome = nome,
        DataCriacao = DateTime.UtcNow,
        };
    }

    public void AtualizarNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new DomainException("O nome do produto é obrigatório.");
        Nome = nome;
        DataAtualizacao = DateTime.UtcNow;
    }
}