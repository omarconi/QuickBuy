using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities.ObjectVal;

namespace QuickBuy.Repository.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(fp => fp.Id);

            builder.Property(fp => fp.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(fp => fp.Descricao)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
