﻿namespace CartaoFidelidade.Application.Clientes;

public class ClienteDTO{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Cpf { get; set; }
    public DateTime DataNascimento { get; set; }
}
