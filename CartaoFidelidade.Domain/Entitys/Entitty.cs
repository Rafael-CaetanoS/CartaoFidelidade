﻿namespace CartaoFidelidade.Domain.Entitys;

public abstract class Entitty
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
}
