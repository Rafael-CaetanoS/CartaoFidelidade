using CartaoFidelidade.Domain.Clientes;
using CartaoFidelidade.Domain.Lojas;
using CartaoFidelidade.Domain.SolicitacaoCupons;

namespace CartaoFidelidade.Domain.Solicitacoes;

public class Solicitacao
{
    public int Id { get; set; }
    public string Status { get; set; }
    public DateTime DataRequisicao { get; set; }
    public Guid ClienteId { get; set; }
    public Cliente Cliente { get; set; }
    public Guid LojaId { get; set; }
    public Loja Loja { get; set; }
    public ICollection<SolicitacaoCupom> CupomSolicitacaos { get; set; }


    public Solicitacao()
    { }

    public Solicitacao(int id, string status, DateTime data, Guid clienteId, Guid lojaId)
    {
        Id = id;
        Status = status;
        DataRequisicao = data;
        clienteId = clienteId;
        lojaId = lojaId;
    }
}
