namespace CartaoFidelidade.Application.Lojas;
public class LojaDTO
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public string Nome { get; set; }
    public string Cnpj { get; set; }
    public string Telefone { get; set; }
}
