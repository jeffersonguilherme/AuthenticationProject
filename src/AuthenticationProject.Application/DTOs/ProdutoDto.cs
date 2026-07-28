namespace AuthenticationProject.Application.DTOs;

public class ProdutoDto
{
    public Guid Id { get; set; }
    public string Name  { get; set; }= string.Empty;
    public DateTime DataCriacao { get; set; }
    public DateTime? DataAtualizacao { get; set; }
}