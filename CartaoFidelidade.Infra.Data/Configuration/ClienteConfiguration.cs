using CartaoFidelidade.Domain.Clientes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CartaoFidelidade.Infra.Data.Configuration;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Clientes");
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Nome).IsRequired().HasMaxLength(100);
        builder.Property(c => c.Email).IsRequired().HasMaxLength(100);
        builder.Property(c => c.Senha).IsRequired().HasMaxLength(250);
        builder.Property(c => c.Telefone).IsRequired().HasMaxLength(15);
        builder.Property(c => c.DataNascimento).IsRequired();
        builder.Property(c => c.Cpf).IsRequired().HasMaxLength(11);
    }
}
