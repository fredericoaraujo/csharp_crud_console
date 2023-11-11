namespace DTO;
public class ClienteEntradaAlteracaoDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateOnly DataNascimento { get; set; }
    public decimal Desconto { get; set; }
}
