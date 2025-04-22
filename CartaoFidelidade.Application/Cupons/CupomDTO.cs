namespace CartaoFidelidade.Application.Cupons;

public class CupomDTO
{
    public int Id { get; set; }
    public string Status { get; set; }
    public DateTime dataCriacao { get; set; }
    public Guid lojaId { get; set; }
    public Guid clienteId { get; set; }
}
