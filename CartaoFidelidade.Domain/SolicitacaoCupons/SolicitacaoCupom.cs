using CartaoFidelidade.Domain.Cupons;
using CartaoFidelidade.Domain.Solicitacoes;

namespace CartaoFidelidade.Domain.SolicitacaoCupons;

public class SolicitacaoCupom
{
    public int Id { get; set; }    
    public int CupomId {  get; set; }
    public Cupom Cupom { get; set; }
    public int SolicitacaoId { get; set; }
    public Solicitacao Solicitacao { get; set; }

    public SolicitacaoCupom()
    {}

    public SolicitacaoCupom(int cupomId, int solicitacaoId)
    {
        this.CupomId = cupomId;
        this.SolicitacaoId = solicitacaoId;
    }
}
