using CartaoFidelidade.Domain.Cupons;
using CartaoFidelidade.Domain.Entitys;
using CartaoFidelidade.Domain.Solicitacoes;

namespace CartaoFidelidade.Domain.Lojas;

public class Loja : Entitty
{
    public string Nome { get; set; }
    public string Cnpj { get; set; }
    public string Telefone { get; set; }
    public ICollection<Cupom> Cupons { get; set; }
    public ICollection<Solicitacao> Solicitacoes { get; set; }


    public Loja()
    { }
    public Loja(Guid id, string email, string senha, string nome, string cnpj, string telefone)
    {
        Id = id;
        Email = email;
        Senha = senha;
        Nome = nome;
        Cnpj = cnpj;
        Telefone = telefone;
    }
}
