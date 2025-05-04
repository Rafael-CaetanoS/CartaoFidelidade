using CartaoFidelidade.Domain.SolicitacaoCupons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CartaoFidelidade.Infra.Data.Configuration;

public class CupomSolicitacaoConfiguration : IEntityTypeConfiguration<SolicitacaoCupom>
{
    public void Configure(EntityTypeBuilder<SolicitacaoCupom> builder)
    {
        builder.ToTable("SolicitacaoCupom");
        builder.HasKey(sc => new { sc.CupomId, sc.SolicitacaoId });
        builder.HasOne(sc => sc.Cupom)
               .WithMany(c => c.CupomSolicitacaos)
               .HasForeignKey(sc => sc.CupomId);
        builder.HasOne(sc => sc.Solicitacao)
               .WithMany(s => s.CupomSolicitacaos)
               .HasForeignKey(sc => sc.SolicitacaoId);
    }
}
