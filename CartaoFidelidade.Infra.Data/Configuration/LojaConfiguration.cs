using CartaoFidelidade.Domain.Lojas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CartaoFidelidade.Infra.Data.Configuration;

public class LojaConfiguration : IEntityTypeConfiguration<Loja>
{
    public void Configure(EntityTypeBuilder<Loja> builder)
    {
        builder.ToTable("Lojas");
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Nome).IsRequired().HasMaxLength(100);
        builder.Property(c => c.Email).IsRequired().HasMaxLength(100);
        builder.Property(c => c.Senha).IsRequired().HasMaxLength(250);
        builder.Property(c => c.Telefone).IsRequired().HasMaxLength(15);
        builder.Property(c => c.Cnpj).IsRequired().HasMaxLength(11);
    }
}
