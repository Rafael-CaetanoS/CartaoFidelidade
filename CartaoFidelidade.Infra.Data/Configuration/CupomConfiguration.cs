using CartaoFidelidade.Domain.Cupons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CartaoFidelidade.Infra.Data.Configuration;

public class CupomConfiguration : IEntityTypeConfiguration<Cupom>
{
    public void Configure(EntityTypeBuilder<Cupom> builder)
    {
        builder.ToTable("Cupons");
        builder.HasKey(c => c.Id);
        builder.Property(c => c.status).IsRequired().HasMaxLength(100);
        builder.Property(c => c.dataCriacao).IsRequired().HasMaxLength(100);
        builder.HasOne(e => e.cliente).WithMany(e => e.Cupons).HasForeignKey(e => e.clienteId);
        builder.HasOne(e => e.loja).WithMany(e => e.Cupons).HasForeignKey(e => e.lojaId);
    }
}
