using AuthenticationProject.Domain.Entities;

namespace AuthenticationProject.Application.Interfaces.Repositories;

public interface IProdutoRepository
{
    Task<Produto?> ObterPorIdAync(Guid id);
    Task<IEnumerable<Produto>> ObterTodosAsync();
    Task AdicionarAsync(Produto produto);
    void Atualizar(Produto produto);
    void Remove(Produto produto);
    Task<bool> SalvarAlteracoesAsync();
}