using CartaoFidelidade.Domain.Clientes;
using CartaoFidelidade.Domain.Lojas;

namespace CartaoFidelidade.Domain.Cupons;

public class Cupom
{
    public int Id { get; set; }
    public string status { get; set; }
    public DateTime dataCriacao { get; set; }
    public Guid lojaId { get; set; }
    public Loja loja { get; set; }
    public Guid clienteId { get; set; }
    public Cliente cliente { get; set; }

    public Cupom()
    {}
    public Cupom(string status, DateTime data, Guid lojaId, Guid clienteId)
    {
        this.status = status;
        this.dataCriacao = data;
        this.lojaId = lojaId;
        this.clienteId = clienteId;
    }
}
