using CartaoFidelidade.Domain.Cupons;
using CartaoFidelidade.Domain.Entitys;
using CartaoFidelidade.Domain.Solicitacoes;

namespace CartaoFidelidade.Domain.Clientes;

public class Cliente : Entitty
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Cpf { get; set; }
    public DateTime DataNascimento { get; set; }
    public ICollection<Cupom> Cupons { get; set; }
    public ICollection<Solicitacao> Solicitacoes { get; set; }


    public Cliente()
    {}

    public Cliente(Guid id, string email, string senha, string nome, string telefone, string cpf, DateTime dataNascimento)
    {
        Id = id;
        Email = email;
        Senha = senha;
        Nome = nome;
        Telefone = telefone;
        Cpf = cpf;
        DataNascimento = dataNascimento;
    }
}