namespace CartaoFidelidade.Application.Solicitacoes;
public class SolicitacaoDTO
{
    public int Id { get; set; }
    public string Status { get; set; }
    public DateTime DataRequisicao { get; set; }
    public Guid ClienteId { get; set; }
    public Guid LojaId { get; set; }
}
